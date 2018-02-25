using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMechanics : MonoBehaviour {
    private float timer;
    private TextMesh threeDText;

    // Use this for initialization
    void Start () {
		this.timer = 45f;
		this.threeDText = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.timer >= 0) {
			this.timer -= Time.deltaTime;

			float displayTimer = Mathf.Round(timer);

			string alignmentText = "";

			if (displayTimer < 10){
				alignmentText = "000";
			} else if (displayTimer < 100){
				alignmentText = "00";
			} 

			this.threeDText.text = "Time Remaining: " + alignmentText + displayTimer + "s";
		}
	}
}
