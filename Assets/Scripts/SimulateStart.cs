using UnityEngine;
using System.Collections;

public class SimulateStart : MonoBehaviour {

//THIS IS TEMPORARY...MEANT TO SIMULATE WHAT A START MENu WILL DO...

	private bool calledStart = false;
	public Countdown countdown;

	// Update is called once per frame
	void Update () {
		if (!calledStart && Time.realtimeSinceStartup > 2) {
			countdown.StartCountdown ();
			calledStart = true;
		}
	}
}
