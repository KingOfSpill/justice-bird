using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollector : MonoBehaviour {

	public UIscript ui;

	// Food trigger
	void OnTriggerEnter(Collider other){

		AudioSource pickUp = GetComponent<AudioSource>();

		if (other.gameObject.CompareTag ("Food")) {

			other.gameObject.SetActive (false);
			Destroy(other.gameObject);
			pickUp.Play ();
			ui.getCoin ();

		}

	}

}