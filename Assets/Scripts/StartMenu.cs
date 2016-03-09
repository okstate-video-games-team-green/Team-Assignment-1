using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class StartMenu : MonoBehaviour {
    
    //public Countdown countdown;
//    public bool hasStarted;
    
    public GameObject button;
    //public GameObject bottleMaker;
    
    // Use this for initialization
	void Start ()
    {
       // hasStarted = false;
    }    
	
	// Update is called once per frame
	void Update () {
	}

    public void GameHasStarted()
    {
        button.SetActive(false);
    }
}
