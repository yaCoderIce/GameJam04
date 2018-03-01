using UnityEngine;

public class GameMenu : MonoBehaviour {

	public FSM m_FSM;
	
	public void PlayGame() {
		Debug.Log("Start the god damn game!");
		m_FSM.ChangeState(State.play);
	}
}
