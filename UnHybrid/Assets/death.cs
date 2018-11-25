using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour {

	void OnTriggerEnter(){
		Destroy(this.gameObject);
	}
}
