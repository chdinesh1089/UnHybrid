using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class board : MonoBehaviour {
public string[] users;
public Text list;

public string url = "http://localhost/game/dataa.php";
	// Use this for initialization
	IEnumerator Start () {
        
		WWW retrieve = new WWW(url);
		yield return retrieve;
		string fulldata = retrieve.text;
		users = fulldata.Split(';');
		for (int i = 0; i< users.Length; i++){
			if (users[i] != "->0"){
			list.text = list.text+ "\n"+ users[i];
			}

		}




		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
