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


      string playerName = PlayerPrefs.GetString("username");
	  if (playerName == "") 
	  {
		  registerer.SetActive(true);

	  }
	  else 
	  registerer.SetActive(false);
	   
		
	}




	
	// Update is called once per frame
	
	public void registerdead () {
		if(name.text != ""){
		
		registerpanel.SetActive(false);
	}
	else 
		registerpanel.SetActive(true);
	}

	public void getName() {
		
		 user = name.text;
registerpanel.SetActive(false);
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
