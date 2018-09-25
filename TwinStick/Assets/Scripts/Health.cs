using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public GameObject DeathParticlePrefab = null;
	private Transform ThisTransform = null;
	public bool ShouldDestroyOnDeath = true;

	void Start()
	{
		ThisTransform = GetComponent<Transform> ();
	}


	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			HeathPoint = 0;
		}
	}

	public float HeathPoint
	{
		get
		{
			return  _HeathPoints;
		}

		set
		{
			_HeathPoints = value;

			if (_HeathPoints <= 0) {
				SendMessage ("Die", SendMessageOptions.DontRequireReceiver);
				if (DeathParticlePrefab != null) {
					Instantiate (DeathParticlePrefab, ThisTransform.position, ThisTransform.rotation);
				}
				if (ShouldDestroyOnDeath)
					Destroy (gameObject);
			}
		}
	}

	[SerializeField]
	private float _HeathPoints = 100f;
}
