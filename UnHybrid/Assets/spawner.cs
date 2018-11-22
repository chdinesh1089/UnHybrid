using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class spawner : MonoBehaviour {

public GameObject wires;
public Vector3 spawnvalues;
private float time =.45f;


public bool stop = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.deltaTime %10 ==0){
			time = time - .01f;

		}
	}

	IEnumerator spawn () {
	  
	   while (!stop)
	   {
		   
		   Vector3 position = new Vector3 (Random.Range(5f,11f),1,Random.Range(-spawnvalues.z,spawnvalues.z));
		   Instantiate(wires, position+transform.TransformPoint (0,0,0),wires.transform.rotation);
		    yield return new WaitForSeconds(time);
	   }
	}
}
