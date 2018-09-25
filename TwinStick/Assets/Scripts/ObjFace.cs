using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFace : MonoBehaviour {

	public Transform ObjToFollow = null;
	public  bool FollowPlayer = false;
	private Transform ThisTransform = null;
	void Awake()
	{
		ThisTransform = GetComponent<Transform> ();

		if (!FollowPlayer) {
			return;
		}

		GameObject PlayerObj = GameObject.FindGameObjectWithTag ("Player");
		if (PlayerObj != null) {
			ObjToFollow = PlayerObj.GetComponent<Transform> ();
		}
	}

	void Update()
	{
		if (ObjToFollow == null)
			return;
		Vector3 DirToObject = ObjToFollow.position - ThisTransform.position;

		if (DirToObject != Vector3.zero)
			ThisTransform.localRotation = Quaternion.LookRotation (DirToObject.normalized, Vector3.up);
	}
}
