using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
 public GameObject player;
 private Vector3 offset; 


	void Start () {
		offset = transform.position;
	}

	void LateUpdate () {
	
		 transform.position = new Vector3(player.transform.position.x + offset.x, offset.y, offset.z);
		
	}
}
