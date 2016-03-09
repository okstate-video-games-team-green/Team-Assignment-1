using UnityEngine;
using System.Collections;

public class FireGun : MonoBehaviour {
	
    public GameObject gunBullet;
	public GameObject gun;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetMouseButtonDown (0)) {
			
            // Create a bullet object.
			GameObject bullet = (GameObject)Instantiate (gunBullet);
			
            //set bullet to position of gun
			bullet.transform.position = gun.transform.position + new Vector3(0,1,10);
			
            //bullet.AddComponent<Rigidbody> ();
			float vertForce = gun.transform.parent.rotation.eulerAngles.x*50;
			float horizForce = gun.transform.parent.rotation.eulerAngles.y*2;
			bullet.GetComponent<Rigidbody> ().AddForce (new Vector3(horizForce, vertForce, 10000));
			
			//bullet.GetComponent<Rigidbody>().AddForce(gun.transform.parent.forward*10000 + gun.transform.up*100000);
			//bullet.AddComponent<SphereCollider> ();
		}
	}
}
