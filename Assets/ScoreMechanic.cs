using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMechanic : MonoBehaviour {
    private TextMesh scoreText;

	public FSM m_FSM;

    // Use this for initialization
    void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		this.scoreText.text = "Treasures: " + m_FSM.treasureScore;
	}
}
