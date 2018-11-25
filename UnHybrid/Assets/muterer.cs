using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class muterer : MonoBehaviour {

	// Use this for initialization
public AudioSource player;
bool ismute = false;
	public void muted (){
		if (ismute == true){
 player.mute = false;
 ismute = false;
		}
		else {
			ismute = true; 
		player.mute = true;
    
		}

	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
