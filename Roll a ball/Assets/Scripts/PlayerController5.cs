using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class PlayerController5 : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	private int count;
	private int negcount;
	public Text countText;
	public Text winText;
	public static float timer=5.0f;
	public Text loseText;
	public Text timeText;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		negcount = 0;
		winText.text = "";
		loseText.text = "";
		timeText.text = "";
		Setcount ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		float vertical1 = (-1) * vertical;
		Vector3 move = new Vector3 (vertical1, 0.0f, horizontal);
		rb.AddForce (move*speed);

	}
	void Update ()
	{timer -= Time.deltaTime;
		timeText.text = "Time :" + ((int)Math.Ceiling (timer)).ToString ();
		if (timer < 0.0f) {
			loseText.text = "You Lose...";
			timeText.text = "Time :" + 0.ToString ();
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("PickUp"))
		{	
		 other.gameObject.SetActive (false);
			count = count + 1;
			Setcount ();
			timer = timer + 1;

	}

}  
	void OnCollisionEnter (Collision Neg)
	{
		if (Neg.gameObject.CompareTag ("Negative")) {
			negcount = negcount - 1;
			timer = timer - 1;
		}

	}
	void OnCollisionStay (Collision Ground)
	{ 

		if (Ground.gameObject.CompareTag ("Ground")) {
			Setcount ();

		}
	}

	void Setcount()
	{ 
		countText.text = "Count:" + (count+negcount).ToString();
			if ((count+negcount) >= 10) {
		winText.text = "You Win!";}
				if (negcount>0){
					loseText.text="You Lose...";
				}

		}
}
