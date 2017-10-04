using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground3Script : MonoBehaviour {

	// Use this for initialization
	private Rigidbody rb4;
	private float timer4 = PlayerController5.timer;
	// Use this for initialization
	void Start () {

		rb4 = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision Grounde){
		if (Grounde.gameObject.CompareTag ("Player")) {
			timer4 = 5.0f;
			PlayerController5.timer = timer4;
		}
	}
}
