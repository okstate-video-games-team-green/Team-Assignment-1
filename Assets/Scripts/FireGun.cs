using UnityEngine;
using System.Collections;

public class FireGun : MonoBehaviour {
	public GameObject gunBullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			// Create a bullet object.
			GameObject bullet = (GameObject)Instantiate (gunBullet);
			// Set the gun barrel as the parent of the bullet.
			bullet.transform.parent = transform;  // Set parent.
			// Set the transform values for the bullet.
			bullet.transform.localPosition = new Vector3 (0f, 0f, 5.0f);
		}
	}
}
