using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour {

	private float time = 300;
	public TankMove TankScript;
	//public GameObject exchangeButton;
	public GameObject gameOverText;


	void Start () {
		gameOverText.SetActive (false);
		//float型からint型へキャストして　String型に変換表示
		GetComponent<Text>().text = ((int)time).ToString();

	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time < 0) {
			StartCoroutine ("GameOver");
		}
		if (time < 0) time = 0;
		GetComponent<Text>().text= ((int)time).ToString();
	}

	IEnumerator GameOver (){
		gameOverText.SetActive (true);
		//exchangeButton.GetComponent<Button> ().interactable = false;
		TankScript.isPlaying = false;
		yield return new WaitForSeconds (2.0f);
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Title");
		}
	}

}
