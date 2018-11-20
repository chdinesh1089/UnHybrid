using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
public GameObject pausepanel;
public GameObject butt;
public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void pauser () {
		pausepanel.SetActive(true);
		player.SetActive(false);
		butt.SetActive(false);
		
	

}

public void continuegame () {
	pausepanel.SetActive(false);
	player.SetActive(true);
	butt.SetActive(true);
	
}
}
