using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScoreDisplay : MonoBehaviour {
	public Text scoreText;

	public FSM m_FSM;


    // Use this for initialization
    void Start () {
		scoreText.text = m_FSM.treasureScore + "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
