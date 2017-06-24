using System.Collections;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour {

	public GameObject shellPrefab;
	public float shotSpeed;
	public AudioClip shotSound;

	private int count = 0;

	void Update(){
		count += 1;
		if(count % 100 == 0){
			EnemyShot();
		}
	}

	public void EnemyShot(){
		GameObject shell = Instantiate (shellPrefab, transform.position, Quaternion.identity) as GameObject;
		Rigidbody shellRigidbody = shell.GetComponent<Rigidbody> ();
		shellRigidbody.AddForce (transform.forward * shotSpeed,ForceMode.Impulse);
		Destroy (shell, 3.0f);
	}
}
