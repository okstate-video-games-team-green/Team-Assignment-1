using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverActions : MonoBehaviour {


	public void PlayAgain(){
		
		SceneManager.LoadScene ("mainScene");
	}

	public void Exit() {
		Application.Quit ();
	}
}
