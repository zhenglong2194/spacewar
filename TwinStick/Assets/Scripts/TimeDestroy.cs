﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroy : MonoBehaviour {

	public float DestroyTime=3.0f;
	void Start(){
		Invoke ("Die", DestroyTime);
	}

	void Die()
	{
		Destroy (gameObject);
	}

}
