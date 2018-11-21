using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour {

	public GameObject pausebutton;	public GameObject player;
	public GameObject spwn;
	public GameObject dist;
	public GameObject panel;
	public string updateurl = "http://unanalyzed-chiefs.000webhostapp.com/update.php";

	public GameObject congrats;
	void OnTriggerEnter () {
		 

	   Destroy (dist);


		Destroy(player);
		Destroy(spwn);
		Destroy(pausebutton);
		panel.SetActive(true);
		if (PlayerPrefs.GetInt("score") >= PlayerPrefs.GetInt("HighScore")){
			congrats.SetActive(true);
				PlayerPrefs.SetInt("HighScore",PlayerPrefs.GetInt("score"));
			 WWWForm form = new WWWForm();
		  form.AddField("playernamePos",PlayerPrefs.GetString("username"));
		form.AddField("scorePos",PlayerPrefs.GetInt("HighScore"));

		WWW www = new WWW(updateurl,form);

		}

		


	}

	public void stop () {
		 Destroy (dist);


		
		Destroy(spwn);
		
		
		if (PlayerPrefs.GetInt("score") >= PlayerPrefs.GetInt("HighScore")){
		
			congrats.SetActive(true);
			 WWWForm form = new WWWForm();
		  form.AddField("playernamePos",PlayerPrefs.GetString("username"));
		form.AddField("scorePos",PlayerPrefs.GetInt("HighScore"));

		WWW www = new WWW(updateurl,form);

		}
	}
public void Update () {
		 Debug.Log(PlayerPrefs.GetInt("HighScore"));
 }
	public void Replay () {
		SceneManager.LoadScene(1);
	}
}
