using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public FSM m_FSM;
	public float m_screenDelay = 3f;
	private float m_countDownTimer;

	public GameObject m_winScreen;
	public GameObject m_looseScreen;


	void Start() {
		m_countDownTimer = m_screenDelay;
		Cursor.visible = true;
		/*
		if(Score.m_score != 0) {
			m_winScreen.SetActive(true);
			m_looseScreen.SetActive(false);
		} else {
			m_winScreen.SetActive(false);
			m_looseScreen.SetActive(true);
		}
		*/
	}

	void Update() {
		if(m_countDownTimer <= 0) {
			m_countDownTimer = m_screenDelay;
			//m_FSM.ChangeState(State.menu);
		} else {
			m_countDownTimer -= Time.deltaTime;
		}
	}

	public void RestartGame() {

		Application.Quit();
	}


}

