using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFlower : MonoBehaviour {

	public GameObject prefab;


	// Use this for initialization
	void Start () {

		InvokeRepeating ("Spawn", 10, 10);
		
	}

	public void Spawn(){
		Instantiate (prefab, transform.position, Quaternion.identity);
	}
	/*
	// Update is called once per frame
	void Update () {
		
	}*/
}
