using UnityEngine;
using System.Collections;

//TODO: The actual gameover stuff
// Called when "Start" button is pressed.
public class DisplayGameOver : MonoBehaviour {

    private float remainingTime;
    private float altRemainingTime; // Used only for AltCountDown()
    private bool gameInProgress = false;

	// Use this for initialization
	void Start () {
        remainingTime = 60f;
        // altRemainingTime = 60f;
        gameInProgress = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Start countdown
        remainingTime -= Time.deltaTime;
        print (remainingTime);
        
        //End countdown
        if (remainingTime <= 0)
        {
            GameOver();
        }
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

	void GameOver() {
		gameInProgress = false;
        print ("Game over");
    }

}
