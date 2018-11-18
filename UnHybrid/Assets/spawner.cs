using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

public GameObject wires;
public Vector3 spawnvalues;
public float time =.5f;


public bool stop = false;

	// Use this for initialization
	void Start () {
		StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator spawn () {
	  
	   while (!stop)
	   {
		   
		   Vector3 position = new Vector3 (Random.Range(0f,transform.position.x),1,Random.Range(-spawnvalues.z,spawnvalues.z));
		   Instantiate(wires, position+transform.TransformPoint (0,0,0),wires.transform.rotation);
		    yield return new WaitForSeconds(time);
	   }
	}
}
