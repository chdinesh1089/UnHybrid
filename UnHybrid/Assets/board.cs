using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class board : MonoBehaviour {
public string[] users;
public Text list;
public GameObject hb;
public string url = "http://localhost/game/dataa.php";
	// Use this for initialization
	IEnumerator Start () {
        
		WWW retrieve = new WWW(url);
		yield return retrieve;
		string fulldata = retrieve.text;
		users = fulldata.Split(';');
		for (int i = users.Length-1; i>=0; i--){
			if (users[i] != "->0" && !(users[i].StartsWith("<")))
			list.text = list.text+ "\n"+ users[i];
			

		}




		
	}
	
public void scoreopener () {
	hb.SetActive(true);
}
}
