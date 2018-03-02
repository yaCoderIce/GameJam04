<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State {
	menu,
	play,
	over
};

public class FSM : MonoBehaviour {

	// Main-Menu -> Play -> Game Win / Game Lose -> Main-Menu
	public GameObject[] m_goStates;

	public State m_gameState = State.menu;

	// Use this for initialization
	void Start () {
		ChangeState(m_gameState);
	}
	
	// Update is called once per frame
	public void ChangeState (State newState) {
		
		m_gameState = newState;

		// Disable all
		for( int i = 0; i < m_goStates.Length; i++) {
			m_goStates[i].SetActive(false);
		}

		// enable the new state
		m_goStates[(int)m_gameState].SetActive(true);
	}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State {
	menu
	, play
	, over
};

public class FSM : MonoBehaviour {

	public int treasureScore;

	// Main-Menu -> Play -> Game Win / Game Lose -> Main-Menu
	public GameObject[] m_goStates;

	public State m_gameState = State.menu;

	// Use this for initialization
	void Start () {
		
		this.ChangeState(this.m_gameState);
	}

	
	// Update is called once per frame
	public void ChangeState (State newState) {
		
		this.m_gameState = newState;

		// Disable all
		for( int i = 0; i < m_goStates.Length; i++) {
			m_goStates[i].SetActive(false);
		}

		// enable the new state
		m_goStates[(int)m_gameState].SetActive(true);
	}

	public void AddToTreasure(int num){
		this.treasureScore += num;
	}
>>>>>>> master
}