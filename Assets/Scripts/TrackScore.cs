using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrackScore : MonoBehaviour {

	public Text scoreText; 
	private int score = 0;

	 void Update(){
		scoreText.text = string.Format ("Score: {0}",score);
	}

	public void IncrementScore () {
		print ("incScore");
		score++;
	}

	//for end of game situation...
	public int GetScore(){
		return score;
	}


}
