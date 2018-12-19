using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficult : MonoBehaviour {

	// Use this for initialization

	public GameObject spawner;
	public double time;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		time++;
		if (time > 900f) {
        spawner.SetActive(true);


		}
	}
}
