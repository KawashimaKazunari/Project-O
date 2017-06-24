using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShotmainShell : MonoBehaviour {
	public GameObject shellPrefab;
	public float shotSpeed;
	public AudioClip shotSound;
	public int shotCount;//弾数
	public Text shellCount;//残弾


	// Use this for initialization
	void Start () {
		shellCount.text = "残弾 :" + shotCount;
		
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			if (shotCount < 1)//弾数の式
				return;
			shot();
			AudioSource.PlayClipAtPoint (shotSound, transform.position);
			shotCount -= 1;//弾数の式
			shellCount.text = "残弾 :" + shotCount;

		}
	}

	public void shot(){
		GameObject shell = (GameObject)Instantiate(shellPrefab, transform.position, Quaternion.identity);
		Rigidbody shellRigibody = shell.GetComponent<Rigidbody> ();
		shellRigibody.AddForce (transform.forward * shotSpeed);
		Destroy (shell, 3.0f);
	}

	//残弾を増やす
	public void AddShell(int amount){
		shotCount += amount;
		shellCount.text = "残弾 :" + shotCount;
	}
}
