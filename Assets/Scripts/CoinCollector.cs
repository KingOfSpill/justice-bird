using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour {

	public UIscript ui;

	// Coin fly to bird trigger
	void OnTriggerEnter(Collider other){

		//AudioSource pickUp = GetComponent<AudioSource>();

		if (other.gameObject.CompareTag ("Coin")) {

			other.gameObject.SetActive (false);
			Destroy(other.gameObject);
			//pickUp.Play ();
			ui.getCoin ();

		}

	}

}