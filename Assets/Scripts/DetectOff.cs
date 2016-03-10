using UnityEngine;
using System.Collections;

public class DetectOff : MonoBehaviour {

	public int yLevel = -2;
	private bool notifiedOff = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!notifiedOff && transform.position.y < yLevel) {
			GetComponentInParent<TrackOffMessages> ().offOccurred ();
		}
	}
		
}
