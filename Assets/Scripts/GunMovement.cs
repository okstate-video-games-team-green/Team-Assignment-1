using UnityEngine;
using System.Collections;
using System;

public class GunMovement : MonoBehaviour {

	public float rotateFactor = 5f;
	public GameObject rotateObject;
	public const float MAX_XGUN_ANGLE = 45;
	public const float MAX_YGUN_ANGLE = 45;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Mouse X"); //influences y axis rotation of gun
		float y = Input.GetAxis ("Mouse Y"); //influences x axis rotation of gun



		//this will translate into negative/positive rotation so it goes well w/ mouse input.
		//unity automatically corrects for this (puts it as positive number
		//Sometimes floating point comparisons do odd things so the check is MAX_XGUN_ANGLE + 1 to be safe
		float initialYAxisRot = (transform.parent.localEulerAngles.y<=(MAX_XGUN_ANGLE + 1))
			? transform.parent.localEulerAngles.y
			:transform.parent.localEulerAngles.y - 360;
		float yAxisRot = Mathf.Clamp(x*rotateFactor + initialYAxisRot, -45, 45);

		/*float initialXAxisRot = (transform.parent.localEulerAngles.x<=(MAX_YGUN_ANGLE + 1))
			? transform.parent.localEulerAngles.x
			:transform.parent.localEulerAngles.x - 360;*/
		float xAxisRot = Mathf.Clamp(transform.parent.localEulerAngles.x - y*rotateFactor, 335, 359);
		transform.parent.localEulerAngles = new Vector3(xAxisRot, yAxisRot, transform.parent.localEulerAngles.z); 


		//similar logic to YAxisRot
	}
}
