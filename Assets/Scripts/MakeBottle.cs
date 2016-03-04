using UnityEngine;
using System.Collections;

public class MakeBottle : MonoBehaviour {

	private int created = 0;
	//public Material material;
	public GameObject bottlePrefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.realtimeSinceStartup>created){
			print ("HERE. Created: " + created);
			GameObject instance = (GameObject)Instantiate (bottlePrefab, new Vector3(2,2), Quaternion.AngleAxis(90, Vector3.right));
			instance.AddComponent<Rigidbody> ();
			created++;
		}
	}
}
