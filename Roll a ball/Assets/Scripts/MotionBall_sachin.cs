using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MotionBall_sachin : MonoBehaviour {

	public float speed;
	//public float jump;
	//public Text countText;
	public Text infoText;
	public Text finalGood;
	//public Text restartText;
	public int count;
	//public int startWait;
	public GameObject block;


	private Rigidbody rb;
	private bool gameOver;




	void Start(){
		//StartCoroutine(WaitStart());
		rb = GetComponent<Rigidbody> ();
		count = 0;
		//SetCountText();
		infoText.text = "";
		finalGood.text = "";
		//restartText.text = "";

	}


	private void Update()
	{
		if (gameOver) {
			if (Input.GetKeyDown(KeyCode.R)) {
				SceneManager.LoadScene("NewLevel_sachin");
			}
		}
	}

	void FixedUpdate () {
		//if (Input.GetKeyDown (KeyCode.F)){
		//	rb.AddForce(new Vector3(0,jump,0));
		//}
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pick_up_sachin")) {
			other.gameObject.SetActive (false);
			infoText.text = "";
			count++;
			//SetCountText();
		} else if (other.gameObject.CompareTag ("Pick_up_sachin_first")) {
			other.gameObject.SetActive (false);
			infoText.text = "DON'T FALL OVER!!!";
		} else if (other.gameObject.CompareTag ("Pick_up_sachin_final")) {
			if (count == 8) {
				other.gameObject.SetActive (false);
				finalGood.text = "WELL DONE!!!\n" +
				"Press 'R' to restart";
				gameOver = true;
			} else {
				other.gameObject.SetActive (false);
				infoText.text = "You didn't collect Everything!!!\n" +
				"Press 'R' to restart";
				gameOver = true;
			}


		} else if (other.gameObject.CompareTag ("Bottom_catcher_sachin")) {
			infoText.text = "YOU FELL OVER!!!\nPress 'R' to restart";
			gameOver = true;
		} else if (other.gameObject.CompareTag ("Disappear_block_sachin")) {
			other.gameObject.SetActive (false);
			block.gameObject.SetActive (false);
			count++;
		}
	}


	//IEnumerator WaitStart() {
	//	yield return new WaitForSeconds(startWait);
	//}


	//void SetCountText() {
	//	countText.text = "Count: " + count.ToString();
	//	if (count >= 12) {
	//		winText.text = "YOU WIN!";
	//		restartText.text = "Press 'R' to restart";
	//		gameOver = true;
	//	}
	//}
}
