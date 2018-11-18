using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hs : MonoBehaviour {

	public Text highscore;
	public GameObject player;
	public Text score;
	// Update is called once per frame
	void Update () {
		highscore.text = PlayerPrefs.GetInt("HighScore").ToString("0");
		score.text = PlayerPrefs.GetInt("score").ToString("0");


	}
}
