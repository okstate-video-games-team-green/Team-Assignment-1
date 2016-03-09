using UnityEngine;
using System.Collections;

public class MakeBottle : MonoBehaviour {

	public int gameOn = 0; // 0 = no; 1 = yes
    public int created = 1;
	public int SpawnRate = 1;
    
    //public Material material;
	public GameObject bottlePrefab;
    
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
		if (gameOn == 1){
            yield return new WaitForSeconds (SpawnRate);
            Instantiate (bottlePrefab);
            print ("HERE. Created: " + created);
            created++;
            StartCoroutine (makeBottles ());
        }

	
	}
}
