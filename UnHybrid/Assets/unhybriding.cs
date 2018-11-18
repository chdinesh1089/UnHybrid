using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unhybriding : MonoBehaviour {
    Vector3 player;
	public bool hit;
	public float damage = .35f;
	 void OnTriggerEnter(Collider other)
 { 
     if(other.tag == "c")
     {
		 hit = true;
		 damage = damage + .05f;
		 transform.localScale = new Vector3( damage, .35f, .35f);
     }
 }

  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
