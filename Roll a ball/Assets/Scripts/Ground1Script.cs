using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {
	private Rigidbody rb2;
	private float timer2 = PlayerController5.timer;
	// Use this for initialization
	void Start () {

		rb2 = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision Grounde){
		if (Grounde.gameObject.CompareTag ("Player")) {
			timer2 = 5.0f;
			PlayerController5.timer = timer2;
		}
	}
}
