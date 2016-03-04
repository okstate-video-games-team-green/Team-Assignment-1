using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrackScore : MonoBehaviour {

	public Text scoreText; 
	private int score = 0;

	public void Start(){
		scoreText.text = string.Format ("Score: {0}",score);
	}

	public void IncrementScore (int amount) {
		score++;
	}

	//for end of game situation...
	public int GetScore(){
		return score;
	}


}
