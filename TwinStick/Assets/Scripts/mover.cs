using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
	private Transform ThisTransform = null;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		ThisTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		ThisTransform.position += ThisTransform.forward * speed * Time.deltaTime;
	}
}
