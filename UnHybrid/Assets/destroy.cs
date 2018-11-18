using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
  
    public float lifetime = 50f;

	// Use this for initialization
	void Update () {
		if (lifetime>0){
			lifetime -= Time.deltaTime;
		}
		if (lifetime<=0){
        Destroy(this.gameObject);
		}

	}
	
	
}
