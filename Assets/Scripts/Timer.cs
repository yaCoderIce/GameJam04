using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

	private float m_time;
	private Text m_UIText;
	

	void Start(){
		m_time = 0.0f;
		m_UIText = GetComponent<Text>();
	}

	void Update() {
		m_time += Time.deltaTime;

		if(m_UIText != null) {
			m_UIText.text = "Time: " + (int)m_time; 
		}
	}
}
