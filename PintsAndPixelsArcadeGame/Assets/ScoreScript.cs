using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

	public static bool detected = false;

	void OnTriggerEnter(Collider c){
		Debug.Log ("Trigger " + gameObject.name + " detected " + c.gameObject.name);
		detected = true;
	}

	public void reset (){
		detected = false;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
