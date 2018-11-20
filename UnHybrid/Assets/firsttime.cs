using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class firsttime : MonoBehaviour {

	// Use this for initialization
	public GameObject registerer;
	public InputField name;
	public string user;
	public string url = "http://localhost/game/dataa.php";
	void Start () {
		PlayerPrefs.SetInt("register",0);
		if (PlayerPrefs.GetInt("register") == 0){
			registerer.SetActive(true);
			//PlayerPrefs.SetInt("register",1);

		}
		else 
		registerer.SetActive(false);
	}


	
	// Update is called once per frame
	void Update () {
		
	}

	public void getName() {
		 user = name.text;
		 WWWForm data = new WWWForm();
		 data.AddField("playernamePost",user);
		 data.AddField("scorePost",0);
		 PlayerPrefs.SetInt("HighScore",0);
	
		 PlayerPrefs.SetString("username",user);

         if (user != ""){
		 WWW www = new WWW (url,data);
		 }

	}
}
