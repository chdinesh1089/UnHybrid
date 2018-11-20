using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pause : MonoBehaviour {
public GameObject pausepanel;
public GameObject butt;
public GameObject player;
	// Use this for initialization
	void Start () {
		
	}

	public void menumaker () {
		SceneManager.LoadScene(0);
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
