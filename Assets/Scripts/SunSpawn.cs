using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSpawn : MonoBehaviour {

	public GameObject prefab;

	void Start () {
		InvokeRepeating ("Spawn", 5, 5);
	}

	void Spawn() {
		Instantiate (prefab, transform.position, Quaternion.identity);
	}
}
