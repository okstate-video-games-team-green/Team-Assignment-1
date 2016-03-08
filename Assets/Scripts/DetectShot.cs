using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DetectShot: MonoBehaviour {

	private TrackScore uiCanvas;
	private GameObject Score;	 	
	void Start(){
		Score = GameObject.Find ("Score");
		uiCanvas = Score.GetComponent<TrackScore> ();
	}

	//TODO: this might need to be OnTrigger
	void OnTriggerEnter(Collider collision){
		//print ("incScore");
		uiCanvas.IncrementScore ();





	}
}