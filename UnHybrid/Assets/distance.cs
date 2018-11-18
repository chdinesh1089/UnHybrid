using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour {


public Transform player;
public Text dist;
public Text high_score;
public int highscore;
	// Use this for initialization
	void Start () {
		highscore = PlayerPrefs.GetInt("HighScore");
		
	}
	
	// Update is called once per frame
	void Update () {
		dist.text = player.position.x.ToString("0") + "m";
		int score = (int) player.position.x;
		PlayerPrefs.SetInt("score",score);
		
		if (score>=highscore){
          highscore =score;
		  PlayerPrefs.SetInt("HighScore",highscore);
		  high_score.text = PlayerPrefs.GetInt("HighScore").ToString("0");
		}
		
		
	}
}
