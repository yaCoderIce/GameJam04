using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestMechanics : MonoBehaviour {
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		//Debug.Log(col.gameObject.name);
		if (col.gameObject.name.Equals("FPSController")){
			Debug.Log(this.transform.parent.name);	
			BuddyGuy.treasureScore++;
			GameObject chest = this.transform.parent.gameObject;
			Destroy(chest);
		}
		
		
		
	}
}
