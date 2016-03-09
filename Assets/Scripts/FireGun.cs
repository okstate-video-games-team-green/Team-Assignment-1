using UnityEngine;
using System.Collections;

public class FireGun : MonoBehaviour {
	
    public GameObject gunBullet;
	public GameObject barrel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
            // Create a bullet object.
			GameObject bullet = (GameObject)Instantiate (gunBullet);
			
            bullet.transform.position = barrel.transform.position;
            
            //set bullet to position of gun
			//bullet.transform.position =barrel.transform.position + new Vector3(0,1,10);
			
            //bullet.AddComponent<Rigidbody> ();
			//float vertForce = barrel.transform.rotation.eulerAngles.x*50;
			//float horizForce = barrel.transform.rotation.eulerAngles.y*2;
			
            bullet.GetComponent<Rigidbody> ().AddForce (transform.forward * 35000);
			
			//bullet.GetComponent<Rigidbody>().AddForce(gun.transform.parent.forward*10000 + gun.transform.up*100000);
			//bullet.AddComponent<SphereCollider> ();
		}
	}
}
