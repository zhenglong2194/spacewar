using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public static int Score;
	public string ScorePrefix = string.Empty;
	public Text ScoreText = null;
	public Text GameOverText = null;
	public static GameController ThisInstance = null;
	void Awake(){
		ThisInstance = this;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreText != null) {
			ScoreText.text = ScorePrefix + Score.ToString ();
		}

	}

	public static void GameOver()
	{
		if (ThisInstance.GameOverText != null) {
			ThisInstance.GameOverText.gameObject.SetActive (true);
		}
	}
}
