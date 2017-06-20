using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollector : MonoBehaviour {

	public int coinScore = 0;

	// Food trigger
	void OnTriggerEnter(Collider other){

		AudioSource pickUp = GetComponent<AudioSource>();

		if (other.gameObject.CompareTag ("Food")) {

			Destroy(other.gameObject);
			pickUp.Play ();
	
		}

	}
}
