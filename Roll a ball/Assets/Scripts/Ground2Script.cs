using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground2Script : MonoBehaviour {

	private Rigidbody rb3;
	private float timer3 = PlayerController5.timer;
	// Use this for initialization
	void Start () {

		rb3 = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision Grounde){
		if (Grounde.gameObject.CompareTag ("Player")) {
			timer3 = 5.0f;
			PlayerController5.timer = timer3;
		}
	}
}
