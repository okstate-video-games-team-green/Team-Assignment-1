using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//TODO: The actual gameover stuff
using UnityEngine.SceneManagement;


public class DisplayGameOver : MonoBehaviour {

	public GameObject gameOverPanel;
	public TrackScore trackScore;
	public HighScoreBank scoreBank;
	public Text highScoreText;

	// Update is called once per frame

	public void GameOver() {
		int lastScore = trackScore.GetScore ();
		if (scoreBank.registerScore(lastScore)) {
			highScoreText.text = "You set the high score of " + scoreBank.highScore;
		} else {
			highScoreText.text = "Your score: " + lastScore.ToString()+ "\nHigh Score:" + scoreBank.highScore.ToString ();
		}
		gameOverPanel.SetActive(true);
    }

	public void PlayAgain(){
		SceneManager.LoadScene ("mainScene");
	}

	public void Exit() {
		Application.Quit ();
	}

}
