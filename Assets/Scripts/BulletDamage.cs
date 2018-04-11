using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Zombie") {
			col.GetComponent<Health> ().doDamage (1);
			Destroy (gameObject);
		}
	}
}
