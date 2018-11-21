using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class firsttime : MonoBehaviour {

	// Use this for initialization
	public GameObject registerer;
	public InputField name;
	public GameObject registerpanel;
	public string user;
	public int indicator;
	public string url = "http://unanalyzed-chiefs.000webhostapp.com/dataa.php";
	void Start () {

	
		if (PlayerPrefs.GetInt("register") == 1){
			registerer.SetActive(true);
			//PlayerPrefs.SetInt("register",1);
			

		}
		
	}




	
	// Update is called once per frame
	void Update () {
		indicator = PlayerPrefs.GetInt("register");
	}
	public void registerdead () {
		if(user != ""){
			PlayerPrefs.SetInt("register",0);

		
		registerpanel.SetActive(false);
	}
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
