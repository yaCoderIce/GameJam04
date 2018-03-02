using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterColliderScript : MonoBehaviour {

	public GamePlay gamePlayState;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.name.Equals("FPSController")){
			Debug.Log("You are dead! Johnny Depp!");
			gamePlayState.GameOver();
		} else if (col.gameObject.name.Equals("crate")) {
			GameObject crate = col.gameObject;
			Destroy(crate);
		}

	}
}
