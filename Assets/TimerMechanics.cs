using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMechanics : MonoBehaviour {
    private float timer;
    private TextMesh threeDText;

    // Use this for initialization
    void Start () {
		this.timer = 0f;
		this.threeDText = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		this.timer += Time.deltaTime;

		float displayTimer = Mathf.Round(timer);

		string alignmentText = "";

		if (displayTimer < 10){
			alignmentText = "000";
		} else if (displayTimer < 100){
			alignmentText = "00";
		} else if (displayTimer < 1000) {
			alignmentText = "0";
		}

		this.threeDText.text = "Time: " + alignmentText + displayTimer + "s";

	}
}
