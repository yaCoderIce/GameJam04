<<<<<<< HEAD:Assets/Scripts/BuddyGuy.cs
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyGuy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Tyler Wrote this
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyGuy : MonoBehaviour {

    // Use this for initialization
    void Start () {
		// Tyler Wrote this
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.name == "crate"){
			GameObject chest = GameObject.Find("treasure_chest_closed");
			for (int i = 0; i < 3; i++){
				Debug.Log(col.gameObject.transform.rotation);
				Quaternion boo = col.gameObject.transform.rotation;
				boo = this.transform.rotation;
				
				Vector3 pos = new Vector3(col.gameObject.transform.position.x, col.gameObject.transform.position.y);
				pos = this.transform.position;
				Instantiate(chest ,pos, boo);
				


				new WaitForSeconds(1);
			}
			Destroy(col.gameObject);
		}
	}
}
>>>>>>> master:Assets/BuddyGuy.cs
