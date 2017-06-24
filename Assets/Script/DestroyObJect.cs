using System.Collections;
using UnityEngine;

public class DestroyObJect : MonoBehaviour {

	void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag ("Shell")) {
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	}
}
