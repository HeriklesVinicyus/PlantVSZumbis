using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadePadrao : MonoBehaviour {

	public Vector2 velocity;

	// Use this for initialization
	/*void Start () {
		
	}*/

	void FixedUpdate(){
		GetComponent<Rigidbody2D>().velocity = velocity;
	}
}
