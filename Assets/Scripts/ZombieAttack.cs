using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour {
	float last = 0;

	void OnCollisionStay2D(Collision2D con){
		if (con.gameObject.tag == "Plant") {
			GetComponent<Animator> ().SetTrigger ("isAttacking");
			if (Time.time - last >= 1) {
				con.gameObject.GetComponent<Health> ().doDamage (1);
				last = Time.time;
			}
		}
	}
}
