using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrackScore : MonoBehaviour {

	public Text scoreText; //TODO:drag this into unity editor
	private int score = 0;

	public void Start(){
		scoreText.text = score.ToString ();
	}

	public void IncrementScore (int amount) {
		//TODO: update score variable & text
		throw new UnityException("Aaron - TODO");
	}

	//for end of game situation...
	public int GetScore(){
		return score;
	}


}
