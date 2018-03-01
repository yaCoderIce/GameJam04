using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeSpawner : MonoBehaviour {

	public float spawnTimeDelay=3f;
	public GameObject cratePreFab;
	public Transform[] spawnPoints;
	public Transform cContainer;
	private int numOfSpawnedCrates;
	private GameObject[] spawnedContainer;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTimeDelay,spawnTimeDelay);
	}
	
	void Spawn(){
		if (numOfSpawnedCrates < 5){
			spawnTimeDelay=Random.Range(3,10);
			int spawnPointIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnPointIndex];
			GameObject nCrate = Instantiate(cratePreFab,spawnPoint.position,spawnPoint.rotation);
			nCrate.name="crate";
			nCrate.transform.parent = cContainer.transform;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		spawnedContainer = GameObject.FindGameObjectsWithTag ("Respawn");
		numOfSpawnedCrates = spawnedContainer.Length;
		Debug.Log("Number of Crates"+numOfSpawnedCrates);
	}
}
