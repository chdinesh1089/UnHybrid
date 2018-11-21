using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hello : MonoBehaviour {

public Text mssg ;

	// Use this for initialization
	void Start () {
		mssg.text = "Hi,  " + PlayerPrefs.GetString("username");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
