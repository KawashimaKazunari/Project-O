using System.Collections;
using UnityEngine;

public class characterMove : MonoBehaviour {

	//機体の設定
	public float maxSpd;
	public float cornering;
	public float basePower;
	//オブジェクト格納
	public Rigidbody myRigid;

	void Start () {
		
	}

	void Update () {
		//PCの動作
		if(Input.GetButton("Horizontal") || Input.GetButton("Vertical")){
			transform.Translate(Vector3.forward * Time.deltaTime * maxSpd * 1 ); //正面
		}


		if(Input.GetButton("Horizontal") || Input.GetButton("Vertical")){
			transform.rotation = Quaternion.LookRotation(transform.position + 
				(Vector3.right * Input.GetAxisRaw("Horizontal")) + 
				(Vector3.forward * Input.GetAxisRaw("Vertical")) 
				- transform.position);
		}
	}

	void FixedUpdate(){
		//旋回処理
		if (myRigid.angularVelocity.magnitude < (myRigid.velocity.magnitude * 0.5f)) {
			myRigid.AddTorque (transform.TransformDirection (Vector3.up) * cornering * Input.GetAxisRaw ("Hrizontal"));
		} else {
			myRigid.angularVelocity = (myRigid.velocity.magnitude * 0.5f) * myRigid.angularVelocity.normalized;
		}
	}
}
