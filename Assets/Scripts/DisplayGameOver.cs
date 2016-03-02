using UnityEngine;
using System.Collections;

//TODO: The actual gameover stuff
public class DisplayGameOver : MonoBehaviour {

	public GameObject gameOverPanel;

	// Update is called once per frame

	public void GameOver() {
        print ("Game over");
		gameOverPanel.SetActive(true);
    }

}
