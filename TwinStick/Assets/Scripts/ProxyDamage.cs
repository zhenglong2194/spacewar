using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour {
	public float DamageRate = 10f;
	void OnTriggerStay(Collider Clo)
	{
		Health H = Clo.gameObject.GetComponent<Health> ();

		if (H == null)
			return;
		H.HeathPoint -= DamageRate * Time.deltaTime;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
