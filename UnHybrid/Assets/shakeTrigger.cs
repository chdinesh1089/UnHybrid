using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;


public class shakeTrigger : MonoBehaviour {
  
	public bool entered;
	public void OnTriggerEnter () {
         entered =true;


	}
	public void OnTriggerExit(){
		entered =false;
		CameraShaker.Instance.ShakeOnce(3f,3f,.1f,1f);
	}
}
