using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {
public int count ;

void Start (){
	PlayerPrefs.SetInt("count",0);
}
	void OnTriggerEnter (Collider x)
{

	if (x.tag == "cap"){
count++;



	}
	PlayerPrefs.SetInt("count",count);
}
}
