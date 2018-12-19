using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour {




public GameObject trig;
public Rigidbody trigger;

 void Update ()  {
	 transform.Translate(-.06f,0f,0f);
	    
trig = GameObject.FindGameObjectWithTag("dead");
trigger = trig.GetComponent<Rigidbody>();
 }  
 
 void OnTriggerEnter (Collider player) {
   if (player.gameObject.tag == "Player") 
   {

   trigger.isKinematic = false;

   }
 }


}
