﻿using System;
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
