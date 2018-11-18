using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleincreaser : MonoBehaviour {

public Vector3 cube;
	
	// Update is called once per frame
	void Start () {
		cube = transform.localScale;
	}
		void Update () {
transform.localScale = cube;
		cube.x = cube.x + Time.deltaTime*10f;
		
			
    
		

	}
}
