using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

	public GameObject prefab;

	public float interval = 0.5f;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Shoot", 0, interval);
	}
	
	// Update is called once per frame
	/*void Update () {
	}*/

	private void Shoot(){
		if (zombieInFrond ()) {
			GetComponent<Animator> ().SetTrigger ("isFiring");
			Instantiate (prefab, transform.position, Quaternion.identity);
		}
	}

	private bool zombieInFrond(){
		Vector2 origen = new Vector2 (9.5f, transform.position.y);
		RaycastHit2D[] hits = Physics2D.RaycastAll (origen, -Vector2.right);

		foreach (RaycastHit2D hit in hits) {
			if (hit.collider != null && hit.collider.tag == "Zombie") {
				return true;
			}
		}
		return false;
	}
}
