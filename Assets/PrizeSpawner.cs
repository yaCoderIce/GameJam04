<<<<<<< HEAD
<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeSpawner : MonoBehaviour {

	public float spawnTimeDelay=3f;
	public GameObject cratePreFab;
	public Transform[] spawnPoints;
	public Transform cContainer;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTimeDelay,spawnTimeDelay);
	}
	
	void Spawn(){
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		GameObject newCrate = Instantiate(cratePreFab,spawnPoints[spawnPointIndex].position,spawnPoints[spawnPointIndex].rotation);
		newCrate.name="crate";
		//newCrate.transform.parent = newCrate.Transform;
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeSpawner : MonoBehaviour {

	public float spawnTimeDelay=3f;
	public GameObject cratePreFab;
	public Transform[] spawnPoints;
	public Transform cContainer;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTimeDelay,spawnTimeDelay);
	}
	
	void Spawn(){
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[spawnPointIndex];
		GameObject nCrate = Instantiate(cratePreFab,spawnPoint.position,spawnPoint.rotation);
		nCrate.name="crate";
		nCrate.transform.parent = cContainer.transform;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
>>>>>>> master
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeSpawner : MonoBehaviour {

	public float spawnTimeDelay=3f;
	public GameObject cratePreFab;
	public Transform[] spawnPoints;
	public Transform cContainer;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", spawnTimeDelay,spawnTimeDelay);
	}
	
	void Spawn(){
		spawnTimeDelay=Random.Range(5,10);
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[spawnPointIndex];
		GameObject nCrate = Instantiate(cratePreFab,spawnPoint.position,spawnPoint.rotation);
		nCrate.name="crate";
		nCrate.transform.parent = cContainer.transform;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
>>>>>>> master
