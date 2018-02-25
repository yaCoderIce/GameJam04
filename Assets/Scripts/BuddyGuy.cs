<<<<<<< HEAD:Assets/Scripts/BuddyGuy.cs
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
=======
﻿﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyGuy : MonoBehaviour {

	public int treasureScore;
    // Use this for initialization
    void Start () {
		treasureScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col){

		Debug.Log("Collided!");
		if (col.gameObject.name == "crate"){
			GameObject chest = GameObject.Find("treasure_chest_closed");
			Debug.Log(col.gameObject.transform.position);
			int numOfTreasures = (int) UnityEngine.Random.Range(1.0f,8.0f);
			Debug.Log("Number of Treasures: " + numOfTreasures);
			for (int i = 1; i <= numOfTreasures; i++){
				
				Quaternion boo = col.gameObject.transform.rotation;
				
				
				Vector3 pos = new Vector3(col.gameObject.transform.position.x, Mathf.Abs(col.gameObject.transform.position.y) * (2 * i), col.gameObject.transform.position.z);
				Debug.Log(pos);
				GameObject newChest = Instantiate(chest ,pos, boo);
				newChest.name = "treasure_chest_closed";
				


				//new WaitForSeconds(1);
			}
			Destroy(col.gameObject);
		} else if (col.gameObject.name == "treasure_chest_closed"){
			//Count scores
			this.treasureScore++;
			Destroy(col.gameObject);
		}
	}
}
>>>>>>> master:Assets/BuddyGuy.cs
