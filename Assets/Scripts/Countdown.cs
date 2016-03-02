using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	private bool gameInProgress = false;
	private float remainingTime;
	private float altRemainingTime; // Used only for AltCountDown()

	public DisplayGameOver gameOverDisplay;
	public Text countdownText;
	public int startTime = 60;

	//make sure the clock shows accurate start value even when start menu is displayed
	public void Start() {
		countdownText.text = startTime.ToString();
	}

	//Not using start method so that another class can control when the timer starts
	public void StartCountdown () {
		remainingTime = startTime;
		// altRemainingTime = 60f;
		gameInProgress = true;
	}

	void Update ()
	{
		if (!gameInProgress) {
			return;
		}
		// Start countdown
		remainingTime -= Time.deltaTime;
		countdownText.text = Math.Ceiling(remainingTime).ToString();

		//End countdown
		if (remainingTime <= 0)
		{
			gameInProgress = false;
			gameOverDisplay.GameOver ();
		}
	}

	public bool GameInProgress() {
		return gameInProgress;
	}

	/*
    AltCountDown() - Alternative to Update().
    Allows the function to end compared to an update script
    which would keep going. I don't know if it's any more
    useful than Update(), but I like the idea.
    */    
	/*public IEnumerator AltCountDown()
	{
		// altRemainingTime = 60
		while (altRemainingTime >= 0) {
			yield return new WaitForSeconds(1);
			altRemainingTime -= 1;
		}
		GameOver();
	}*/
		
}