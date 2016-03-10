using UnityEngine;
using System.Collections;

public class TrackOffMessages : MonoBehaviour {

	public TrackScore scoreTracker;
	public int numberOfOffs; //number of items knocked off pyramid to have score count
	private int offsLeft;


	// Use this for initialization
	void Start () {
		offsLeft = numberOfOffs;
		if (scoreTracker == null) {
			scoreTracker = FindObjectOfType<TrackScore> ();
			print (scoreTracker);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void offOccurred() {
		offsLeft--;
		if (offsLeft== 0) {
			scoreTracker.IncrementScore ();
		}
	}
}
