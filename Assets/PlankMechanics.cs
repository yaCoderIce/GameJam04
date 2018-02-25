/**
	This 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankMechanics : MonoBehaviour {

	public float m_sway;
	public int m_swingCounter;

	private bool moveLeft;

	private int counter;
	private float modifier;

	private int rockingCount;
    private GameObject textTest;

    // Use this for initialization
    void Start () {
		counter = 0;
		m_sway = .55f;
		m_swingCounter = 0;
		
		moveLeft = true;

		rockingCount = -15;

		modifier = -1f;
		//this.rigidbody = GetComponent<Rigidbody>();
		//this.buddyGuy = transform.Find("ThirdPersonController");
		//this.rigidbody.AddForce(Vector3.up * 10f);

		transform.Rotate(0,0,m_sway*modifier);

		this.textTest = GameObject.Find("Timer");
	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log(this.textTest.name);
		//this.textTest.SetActive(!this.textTest.activeSelf);
		
		counter += 1;
		if (counter % 2 == 0){
			
			Debug.Log("Swing Counter :" + m_swingCounter + " modifier :" + modifier);
			if (moveLeft){
				m_swingCounter++;
				if (m_swingCounter > (-1 * rockingCount)){
					moveLeft = false;
					modifier = 1f;
				} 
			} else {

				m_swingCounter--;
				if (m_swingCounter < rockingCount){
					moveLeft = true;
					modifier = -1f;
				}
			}

			
			//transform.Translate(Vector3.right * m_sway *modifier);
			//transform.Rotate(2 * modifier,0,0);
			transform.Rotate(0,0,m_sway*modifier);
		}
		
	}

}
