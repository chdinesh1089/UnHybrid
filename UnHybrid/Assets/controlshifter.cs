using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlshifter : MonoBehaviour {

    public GameObject tilt;
	public GameObject stick;
	public bool istilt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


		
	}

	public void controller (){
		if (istilt == true){
			tilt.SetActive(true);
			stick.SetActive(false);
			istilt = false;

		}
		else if (istilt == false){
			tilt.SetActive(false);
			stick.SetActive(true);
			istilt = true;

		}

	}
}
