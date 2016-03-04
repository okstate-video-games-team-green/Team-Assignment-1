using UnityEngine;
using System.Collections;

public class DetectShot: MonoBehaviour {

	public TrackScore scoreTracker;
	public int scoreIncrAmt;


	//TODO: this might need to be OnTrigger
	//TODO: Make sure this is a real method
	public void OnCollision(Collision col){
		scoreTracker.IncrementScore (scoreIncrAmt);
	}
}
