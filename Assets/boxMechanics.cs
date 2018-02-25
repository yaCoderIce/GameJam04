using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxMechanics : MonoBehaviour {
	public Transform treasContainer; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col){
		Debug.Log(col.gameObject.name);
		if (col.gameObject.name.Equals("FPSController")){
			GameObject chest = GameObject.Find("treasure_chest_closed");
			
			int numOfTreasures = (int) UnityEngine.Random.Range(1.0f,8.0f);
			
			Debug.Log("Number of Treasures: " + numOfTreasures);
			
			for (int i = 1; i <= numOfTreasures; i++){
				
				Quaternion boo = col.gameObject.transform.rotation;
				
				
				Vector3 pos = new Vector3((0.03f * (float) numOfTreasures * col.gameObject.transform.position.x), Mathf.Abs(col.gameObject.transform.position.y) * (2 * i), col.gameObject.transform.position.z);
				
				GameObject newChest = Instantiate(chest ,pos, boo);
				newChest.name = "treasure_chest_closed";
				newChest.transform.parent = treasContainer.transform;


				//new WaitForSeconds(1);
			}
			Destroy(this.transform.parent.gameObject);
		} 

	}
}
