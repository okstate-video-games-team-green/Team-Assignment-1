using UnityEngine;
using System.Collections;

public class MakeBottle : MonoBehaviour {

	public int gameOn = 0; // 0 = no; 1 = yes
    public int created = 1;
	public int SpawnRate = 1;
    
    //public Material material;
	public GameObject bottlePrefab;
	public GameObject cratePrefab;
	public GameObject pinPrefab;
	public GameObject duckPrefab;

    
	void Start ()
    {
        //StartCoroutine (makeBottles ());
    }

	
	// Update is called once per frame
	void Update () {
//		timeStart= Time.realtimeSinceStartup;
//		if (Time.realtimeSinceStartup - timeStart>created){
//			print ("HERE. Created: " + created);
//			//GameObject instance = (GameObject)Instantiate (bottlePrefab, new Vector3(2,2), Quaternion.AngleAxis(90, Vector3.right));
//			//instance.AddComponent<Rigidbody> ();
//			created++;
		//}
	}

    public void StartGame() {
        gameOn = 1;
        StartCoroutine (makeBottles());
    }
    
	public IEnumerator makeBottles(){
		if (gameOn == 1) {
			yield return new WaitForSeconds (SpawnRate);
			Instantiate (bottlePrefab);
			created++;
			StartCoroutine (makeCrates ());
		}
	}

	
		public IEnumerator makeCrates(){
		if (gameOn == 1) {
			yield return new WaitForSeconds (SpawnRate);
			Instantiate (cratePrefab);
			created++;
			StartCoroutine (makePins ());
		}
	}


			public IEnumerator makePins(){
		if (gameOn == 1) {
			yield return new WaitForSeconds (SpawnRate);
			Instantiate (pinPrefab);
			created++;
			StartCoroutine (makeDucks ());
		}
	}


				public IEnumerator makeDucks(){
		if (gameOn == 1) {
			yield return new WaitForSeconds (SpawnRate);
			Instantiate (duckPrefab);
			created++;
			StartCoroutine (makeBottles ());
		}
	}




}