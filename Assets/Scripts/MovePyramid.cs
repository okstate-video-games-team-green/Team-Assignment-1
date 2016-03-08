using UnityEngine;
using System.Collections;

public class MovePyramid : MonoBehaviour {


	public GameObject pyramid;
	public float speed;



	// Use this for initialization
	void Start () {


		pyramid.transform.position = new Vector3 (-25, 0, 10);
			
	
	}

	// Update is called once per frame
	void Update () {
	

		pyramid.transform.position = pyramid.transform.position + new Vector3 (1 * speed, 0, 0);

//		
			




	}
}