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
	public string url = "http://unanalyzed-chiefs.000webhostapp.com/dataa.php";
	void Start () {
		
		if (PlayerPrefs.GetInt("register") == 0){
			registerer.SetActive(true);
			//PlayerPrefs.SetInt("register",1);
			PlayerPrefs.SetInt("register",1);

		}
		else 
		registerer.SetActive(false);
	}


	
	// Update is called once per frame
	void Update () {
		
	}
	public void registerdead () {
		registerpanel.SetActive(false);
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
