using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movem : MonoBehaviour {


public Vector3 spawner;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	spawner  = gameObject.transform.position;
	spawner.x += (Time.deltaTime*20f);
	gameObject.transform.position = spawner;
	}
}
