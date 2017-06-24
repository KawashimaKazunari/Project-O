using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellItem : MonoBehaviour {

	private GameObject shotShell;//shotShellの情報を入れる箱
	public int reload;//回復数の情報を入れる変数

	void OnTriggerEnter(Collider other){
		Debug.Log ("A");
		if (other.CompareTag ("Player")) {
			Debug.Log ("B");
			shotShell = GameObject.Find ("ShotmainShell");
			ShotmainShell ss = shotShell.GetComponent<ShotmainShell> ();
			ss.AddShell (reload);
			Destroy (gameObject);
		}
	}
}
