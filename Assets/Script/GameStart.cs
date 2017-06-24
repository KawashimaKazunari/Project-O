using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour {

	public void OnStartButtonClicked(){
		SceneManager.LoadScene ("Main");
	}
}
