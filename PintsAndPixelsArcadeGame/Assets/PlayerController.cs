using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			
		}
		if (Input.GetKeyDown (KeyCode.A)) {

		}
		if (Input.GetKeyDown (KeyCode.P)) {

		}
		if (Input.GetKeyDown (KeyCode.L)) {

		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += Vector3.up * Time.deltaTime * speed;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position += Vector3.down * Time.deltaTime * speed;
		}
	}
}
