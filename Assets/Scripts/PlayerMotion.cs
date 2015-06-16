using UnityEngine;
using System.Collections;

public class PlayerMotion : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (forwardFree()){
			transform.position += Vector3.forward * Time.deltaTime;	
		}
	}

	bool forwardFree(){
		return !(Physics.Raycast(transform.position, Vector3.forward, 1));
	}
}