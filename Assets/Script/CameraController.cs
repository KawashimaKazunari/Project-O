using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Camera mainCamera;
	public Camera subCamera;

	// Use this for initialization
	void Start () {
		
		subCamera.enabled = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		//Fire2のボタンをおしている間は
		if (Input.GetButton ("Fire2")) {
			mainCamera.enabled = false;//メインカメラを無効にする
			subCamera.enabled = true;//サブカメラを有効にする
		} else {
			mainCamera.enabled = true;
			subCamera.enabled = false;
		}
	}
}
