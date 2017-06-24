using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShell : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Shell")) {
			Destroy (other.gameObject);
		}
	}
}
