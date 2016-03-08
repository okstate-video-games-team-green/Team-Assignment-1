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
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "ball(Clone)") {
			Destroy (col.gameObject);
		} else {
			uiCanvas.IncrementScore ();
			Destroy (col.gameObject);
		}
	}
}