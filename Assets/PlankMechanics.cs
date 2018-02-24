/**
	This 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankMechanics : MonoBehaviour {

	public int m_sway;
	public bool m_left;
	// Use this for initialization
	void Start () {
		m_sway = 15;
		m_left = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (m_left){
			//transform.rotation += Vector3.Angle * (m_sway * Time.deltaTime);
			
		} else {
			transform.position -= Vector3.forward * (m_sway * Time.deltaTime);
		}
		//m_left = !m_left;
	}
}
