using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {


  public AudioClip blast;
  public float volume;
  public AudioSource player;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter () {
		player.PlayOneShot(blast,volume);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
