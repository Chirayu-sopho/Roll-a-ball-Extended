using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground4Script : MonoBehaviour {

	// Use this for initialization
	private Rigidbody rb5;
	private float timer5 = PlayerController5.timer;
	// Use this for initialization
	void Start () {

		rb5 = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision Grounde){
		if (Grounde.gameObject.CompareTag ("Player")) {
			timer5 = 5.0f;
			PlayerController5.timer = timer5;
		}
	}
}
