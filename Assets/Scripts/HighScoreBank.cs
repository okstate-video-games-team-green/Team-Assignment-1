using UnityEngine;
using System.Collections;

public class HighScoreBank : MonoBehaviour {

	private static bool created;
	private int _highScore;

	public int highScore {
		get {return _highScore;}
	}

	void Awake(){
		_highScore = PlayerPrefs.GetInt ("high_score"); //will be 0 if not there
	}

	//returns true if the new score is a high score
	public bool registerScore(int score) {
		if (score > _highScore) {
			_highScore = score;
			PlayerPrefs.SetInt ("high_score", score);
			return true;
		}
		return false;
	}

	public void OnApplicationQuit() {
		PlayerPrefs.DeleteKey ("high_score"); //interpreting "since play began" as this
	}


}