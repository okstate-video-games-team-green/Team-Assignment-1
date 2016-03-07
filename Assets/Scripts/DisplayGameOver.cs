using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//TODO: The actual gameover stuff
public class DisplayGameOver : MonoBehaviour {

	public GameObject gameOverPanel;
	public TrackScore trackScore;
	public Text highScoreText;
	private int highScoreValue = 0;

	// Update is called once per frame

	public void GameOver() {
		int lastScore = trackScore.GetScore ();
		if (highScoreValue < lastScore) {
			highScoreValue = lastScore;
			highScoreText.text = "You set the high score of " + highScoreValue.ToString ();
		} else {
			highScoreText.text = "Your score: " + lastScore.ToString()+ "\nHigh Score:" + highScoreValue.ToString ();
		}
		gameOverPanel.SetActive(true);
		
    }

	void Awake(){
		DontDestroyOnLoad (this);//for keeping high score in memory
	}

}
