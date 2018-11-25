using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class errrorsol : MonoBehaviour {
     public int c;
	 public GameObject ind;

	 void Update (){
		 if (c > 1){
			 ind.SetActive(true);


		 }
		 else 
		 ind.SetActive(false);

	 }
	void OnTriggerEnter (Collider obj){
if (obj.tag == "c"){
	c++;

}
	}

	void OnTriggerExit(Collider obj){
if (obj.tag == "c"){
 c--;
}
}}
