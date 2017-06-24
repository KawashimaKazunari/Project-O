using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankHeaith : MonoBehaviour {

	//public GameObject effectPrefab1;
	//public GameObject effectPrefab2;
	public int tankHP;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "EnemyShell") {
			tankHP -= 1;
			Destroy (other.gameObject);

			if (tankHP > 0) {
//				GameObject effect1 = (GameObject)Instantiate (effectPrefab1, transform.position, Quaternion.identity);
//				Destroy (effect1, 1.0f);
//			} else {
//				GameObject effect2 = (GameObject)Instantiate (effectPrefab2, transform.position, Quaternion.identity);
//             Destroy (effect2, 1.0f);

				//Destroy (gameObject);
				this.gameObject.SetActive(false);
				Invoke ("GotoGameOver", 1.5f);
			}
		}
	}

	void GoToGameOver(){
		SceneManager.LoadScene ("GameOver");
	}

}
