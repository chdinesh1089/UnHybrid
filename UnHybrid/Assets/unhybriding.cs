using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unhybriding : MonoBehaviour {
    Vector3 player;
	
	public GameObject helper;
	public bool hit;
	public float damage = .35f;
	public bool death;
	public float starttime;
	 void OnTriggerEnter(Collider other)
 { 
     if(other.tag == "c")
     {
		  hit = true;
		 damage = damage + .025f;
		 transform.localScale = new Vector3( damage, damage, .35f);
		 death = true;
		

		
		
     }
 }
 void OnTriggerExit(Collider other)
 { 
     if(other.tag == "c")
     {
		  death = false;
		  starttime =Time.time;


		
		
     }
 }

 

  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (death == true){
starttime = Time.time-starttime;
if (starttime > 20f) {
		helper.SetActive(true);
}



		}
		else 
		starttime =0f;
	}


}
