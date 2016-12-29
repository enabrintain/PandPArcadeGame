using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1;
	public float boardTiltAngle = 3f;
	private float currentAngle = 0;
	private float angleLimit = 45;
	private float deg2Rad = 0.0174533f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float f = Mathf.Sin(boardTiltAngle*deg2Rad);

		if (Input.GetKey (KeyCode.Q)) {
			transform.Rotate(Vector3.right * Time.deltaTime * speed);
			currentAngle = transform.rotation.x;
			if (transform.rotation.eulerAngles.x > (360 - angleLimit))
				Mathf.Clamp (transform.rotation.eulerAngles.x, (360 - angleLimit), 360);
			else
				Mathf.Clamp (transform.rotation.eulerAngles.x, 0, angleLimit);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.left * Time.deltaTime * speed);
			currentAngle = transform.rotation.x;
			//Debug.Log (transform.rotation.eulerAngles.x+" "+transform.rotation.eulerAngles.y+" "+transform.rotation.eulerAngles.z+" "+ angleLimit*deg2Rad);
			if (transform.rotation.eulerAngles.x > (360 - angleLimit))
				Mathf.Clamp (transform.rotation.eulerAngles.x, (360 - angleLimit), 360);
			else
				Mathf.Clamp (transform.rotation.eulerAngles.x, 0, angleLimit);
		}
		if (Input.GetKey (KeyCode.P)) {
			transform.Rotate(Vector3.left * Time.deltaTime * speed);
			currentAngle = transform.rotation.x;
			Mathf.Clamp (transform.rotation.x, -angleLimit*deg2Rad, angleLimit*deg2Rad);
		}
		if (Input.GetKey (KeyCode.L)) {
			transform.Rotate(Vector3.right * Time.deltaTime * speed);
			currentAngle = transform.rotation.x;
			Mathf.Clamp (transform.rotation.x, -angleLimit*deg2Rad, angleLimit*deg2Rad);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += new Vector3(0f,1f,f) * Time.deltaTime * speed;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += new Vector3(0f,-1f,-f) * Time.deltaTime * speed;
		}
	}
}
