﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureMechanics : MonoBehaviour {
    
    private TextMesh scoreText;

    // Use this for initialization
    void Start () {
		this.scoreText = GetComponent<TextMesh>();
		this.scoreText.text = "Treasures: " + BuddyGuy.treasureScore;
	}
	
	// Update is called once per frame
	void Update () {
		this.scoreText.text = "Treasures: " + BuddyGuy.treasureScore;
	}
}
