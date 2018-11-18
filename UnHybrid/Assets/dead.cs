using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour {

	
	public GameObject player;
	public GameObject spwn;
	public GameObject dist;
	public GameObject panel;
	public GameObject congrats;
	void OnTriggerEnter () {

	   Destroy (dist);


		Destroy(player);
		Destroy(spwn);
		panel.SetActive(true);
		if (PlayerPrefs.GetInt("score") >= PlayerPrefs.GetInt("HighScore")){
			congrats.SetActive(true);

		}


	}
}
