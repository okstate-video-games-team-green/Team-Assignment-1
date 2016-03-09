using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

	private bool gameInProgress = false;
	private float remainingTime;


	public DisplayGameOver gameOverDisplay;
	public Text countdownText;
	public int startTime = 60;
	public MakeBottle makeBottle;

	//make sure the clock shows accurate start value even when start menu is displayed
	public void Start() {
		countdownText.text = startTime.ToString();
	}

	//Not using start method so that another class can control when the timer starts
	public void StartCountdown () {
		remainingTime = startTime;
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
			makeBottle.gameOn = 0;

		}
	}

	public bool GameInProgress() {
		return gameInProgress;
	}
}