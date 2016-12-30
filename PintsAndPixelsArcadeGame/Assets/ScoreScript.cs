using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
	public int value;
	public Text score;

	public static bool detected = false;

	void OnTriggerEnter(Collider c){
		//Debug.Log ("Trigger " + gameObject.name + " detected " + c.gameObject.name);
		detected = true;
		ScoreKeeper.registerScore (gameObject, value);
	}

	public void reset (){
		detected = false;
	}


	// Use this for initialization
	void Start () {
		if (score)
			score.text = ScoreKeeper.getScore().ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
