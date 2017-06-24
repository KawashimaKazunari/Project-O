using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TankMove : MonoBehaviour {

	public float moveSpeed;
	public float turnSpeed;

	private Rigidbody rb;
	private float movementInputValue;
	private float turnInputValue;

	public bool isPlaying = true;

	private bool gameClear = false;
	public Text clearText;

	void Awake(){
		rb = GetComponent<Rigidbody>();
	}

	void Update () {
		
			if (isPlaying) {
				movementInputValue = Input.GetAxis ("Vertical");
				turnInputValue = Input.GetAxis ("Horizontal");
			}
	}

	void FixedUpdate(){
		if (!gameClear) {
			Move ();  // Move関数（命令ブロック）を呼び出す
			Turn ();  // Turn関数（命令ブロック）を呼び出す
		} else {
			clearText.enabled = true;
			Invoke ("CallTitle", 2);
		}
	}


	// 前進・後退の命令ブロック
	void Move(){

		Vector3 movement = transform.forward * movementInputValue * moveSpeed * Time.deltaTime;

		rb.MovePosition(rb.position + movement);
	}


	// 旋回の命令ブロック
	void Turn(){

		float turn = turnInputValue * turnSpeed * Time.deltaTime;

		Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

		rb.MoveRotation(rb.rotation * turnRotation);

	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "ClearZone") {
			gameClear = true;
		}
	}

	void CallTitle(){
		Application.LoadLevel ("Title");
	}
}
