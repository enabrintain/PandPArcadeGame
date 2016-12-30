using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {
	
	public GameObject lever;
	public Text scoreLabel;
	public Text ballLabel;
	public int ballCt = 4;
	static GameObject _lever;
	static Text _scoreLabel;
	static Text _ballLabel;
	static int _ballCt = 3;

	static int score = 0;
	static List<GameObject> registeredTargets = new List<GameObject> ();
	static bool scored = false;
	static Vector3 initPos;
	static Quaternion initRot;


	public static void registerScore(GameObject scoringHole, int value){
		score += value;
		scored = true;
		registeredTargets.Add (scoringHole);
		scored = true;
		_scoreLabel.text = score.ToString ();
	}

	public static void registerBallDrop(GameObject ball){
		Debug.Log ("registerBallDrop");
		if (scored)
			reset (ball);
		else {
			_ballCt--;
			_ballLabel.text = _ballCt.ToString ();
			if(_ballCt<1)
				gameOver (ball);
			else
				reset (ball);
		}
		scored = false;
	}

	public static void reset (GameObject ball){
		// return lever to starting point, then terurn ball to lever
		_lever.transform.rotation = initRot;
		_lever.transform.position = initPos;
		ball.transform.position = new Vector3 (.86f, -20.32f, -1.75f);
	}

	public static void gameOver (GameObject ball){
		Destroy (ball);
		// go to end screen
		GameObject.Find("LevelManager").GetComponent<LevelManager>().loadLevel("gameOver");
	}

	public static int getScore(){
		return score;
	}

	// Use this for initialization
	void Start () {
		_lever = lever;
		_scoreLabel = scoreLabel;
		_ballLabel = ballLabel;
		_ballCt = ballCt;
		initRot = _lever.transform.rotation;
		initPos = _lever.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
