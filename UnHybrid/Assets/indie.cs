using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indie : MonoBehaviour {


public GameObject[] black;
	// Use this for initialization
	void Start () {
		black[0].SetActive(false);
		black[1].SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.deltaTime % 7 ==0){
			
		int rand = (int) Random.Range(1,9);

		if (rand%3 ==0){
			

		}
	}
	}
}
