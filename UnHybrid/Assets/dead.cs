using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour {

	
	public GameObject player;
	public GameObject spwn;
	void OnTriggerEnter () {

		
		Destroy(player);
		Destroy(spwn);

	}
}
