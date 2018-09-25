using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammomanager : MonoBehaviour {
	public GameObject AmmoPrefab = null;
	public int PoolSize = 100;
	public Queue<Transform> AmmoQueue = new Queue<Transform>();
	private GameObject[] AmmoArry;
	public static Ammomanager AmmoManagerSingleton = null;

	void Awake()
	{
		if (AmmoManagerSingleton != null) {
			Destroy (GetComponent<Ammomanager> ());
			return;
		}

		AmmoManagerSingleton = this;
		AmmoArry = new GameObject[PoolSize];

		for (int i = 0; i < PoolSize; i++) {
			AmmoArry [i] = Instantiate (AmmoPrefab, Vector3.zero, Quaternion.identity) as GameObject;
			Transform ObjTransform = AmmoArry [i].GetComponent<Transform> ();
			ObjTransform.parent = GetComponent<Transform> ();
			AmmoQueue.Enqueue (ObjTransform);
			AmmoArry [i].SetActive (false);
		}
	}

	public static Transform SpawnAmmo(Vector3 Position,Quaternion Rotation)
	{
		Transform SpawnedAmmo = AmmoManagerSingleton.AmmoQueue.Dequeue ();

		SpawnedAmmo.gameObject.SetActive (true);
		SpawnedAmmo.position = Position;
		SpawnedAmmo.localRotation = Rotation;

		AmmoManagerSingleton.AmmoQueue.Enqueue (SpawnedAmmo);
		return SpawnedAmmo;
	}
}
