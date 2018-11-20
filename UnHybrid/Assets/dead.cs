using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour {

	public GameObject pausebutton;	public GameObject player;
	public GameObject spwn;
	public GameObject dist;
	public GameObject panel;
	public GameObject congrats;
	void OnTriggerEnter () {

	   Destroy (dist);


		Destroy(player);
		Destroy(spwn);
		Destroy(pausebutton);
		panel.SetActive(true);
		if (PlayerPrefs.GetInt("score") >= PlayerPrefs.GetInt("HighScore")){
			congrats.SetActive(true);

		}

		


	}

	public void Replay () {
		SceneManager.LoadScene(1);
	}
}
