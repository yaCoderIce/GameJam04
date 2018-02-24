/**
	This 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankMechanics : MonoBehaviour {

	public int m_sway;
	public bool m_left;

	GameObject cube;

    // Use this for initialization
    void Start () {
		m_sway = 15;
		m_left = false;

		this.cube = GameObject.Find("Cube");
		//this.buddyGuy = transform.Find("ThirdPersonController");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(transform.tag);
		//transform.position += Vector3.forward * (Time.deltaTime);
		if (m_left){
			
			
		} else {
			//transform.position -= Vector3.forward * (m_sway * Time.deltaTime);
		}
		//m_left = !m_left;
	}

}
