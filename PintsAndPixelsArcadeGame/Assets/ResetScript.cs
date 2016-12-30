using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour {
	public GameObject target;


	void OnTriggerEnter(Collider c){
		//Debug.Log (c.gameObject.name+" colided.");
		if (c.gameObject.name.Equals (target.name)) {
			//Debug.Log (c.gameObject.name+" detected.");
			ScoreKeeper.registerBallDrop (c.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
