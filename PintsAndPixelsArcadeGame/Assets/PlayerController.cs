using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1;
	private float currentAngle = 0;
	private float angleLimit = 45;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Q)) {
			transform.Rotate(Vector3.right * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(Vector3.left * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.P)) {
			transform.Rotate(Vector3.left * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.L)) {
			transform.Rotate(Vector3.right * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			float f = 3 / 4;
			transform.position += new Vector3(0f,1f,f) * Time.deltaTime * speed;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += Vector3.down * Time.deltaTime * speed;
		}
	}
}
