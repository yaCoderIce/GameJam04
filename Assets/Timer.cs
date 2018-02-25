using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	float timer;
	int counter;
    private TextMesh threeDText;

    // Use this for initialization
    void Start () {
		timer =0f;
		counter = 0;

		this.threeDText = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
			string bufferText = "";
		
			Debug.Log("Time: " + timer);
			float l_timer = Mathf.Round(timer);
			if (l_timer < 10){
				bufferText = "000";
			} else if (l_timer < 100){
				bufferText = "00";
			} else if (l_timer < 1000){
				bufferText = "0";
			}
			this.threeDText.text = "Time: " + bufferText + l_timer + "s";
			//this.threeDText.text = Time.deltaTime.ToString();
				
	}
}
