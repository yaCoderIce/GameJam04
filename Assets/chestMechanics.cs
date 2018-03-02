using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestMechanics : MonoBehaviour {
    
	public FSM m_FSM;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		//Debug.Log(col.gameObject.name);
		if (col.gameObject.name.Equals("FPSController")){
			Debug.Log(this.transform.parent.name);	
			m_FSM.AddToTreasure(1);
			Debug.Log(m_FSM.m_gameState);
			GameObject chest = this.transform.parent.gameObject;
			Destroy(chest);
		}
		
		
		
	}
}
