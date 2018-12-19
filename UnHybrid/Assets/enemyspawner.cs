using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour {



public GameObject wires;
public Vector3 spawnvalues;
private float time =5f;

	// Use this for initialization

	public bool stop = false;
	void Awake () {
		StartCoroutine(spawn());
	}
	
	// Update is called once per frame
	void Update () {
			if (Time.deltaTime %10 ==0){
			time = time - .01f;

		}
		
	}

    IEnumerator spawn ()
    {

		while (!stop)
	   {
		   
		   Vector3 position = new Vector3 (Random.Range(25f,30f),1,Random.Range(-spawnvalues.z,spawnvalues.z));
		   Instantiate(wires, position+transform.TransformPoint (0,0,0),wires.transform.rotation);
		    yield return new WaitForSeconds(time);
	   }
      
    }
}
