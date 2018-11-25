using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class board : MonoBehaviour {
public string[] users;
public string[] items;
public Text list;
public Text list2; 
public GameObject mainmenu;
public GameObject reds;
public GameObject hb;
public string url = "http://unanalyzed-chiefs.000webhostapp.com/dataa.php";
	// Use this for initialization

	IEnumerator Start () {
        
		WWW retrieve = new WWW(url);
		yield return retrieve;
		string fulldata = retrieve.text;
		users = fulldata.Split(';');
		int n =0;
		list.text = "";
		for (int i = users.Length-1; i>=0; i--){
			n++;
			if (users[i] != "->0" && !(users[i].StartsWith("<"))){
				items = users[i].Split(':');
			list.text = list.text+ "\n"+n+".  "+ items[0];
			list2.text = list2.text + "\n" + items[1];
			}

		}




		
	}
	
public void scoreopener () {
	hb.SetActive(true);
	mainmenu.SetActive(false);
	reds.SetActive(false);


}
public void hsbback () {
	mainmenu.SetActive(true);
	hb.SetActive(false);
	reds.SetActive(true);

}

public void exitgame () {
	Application.Quit();
}
}
