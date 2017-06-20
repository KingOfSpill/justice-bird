using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpanner : MonoBehaviour {

	public GameObject coins;
	public float delay = 10.0f;
	public bool active = true;

	void Start () {
		
		StartCoroutine (CoinGenerator ());
	}

	IEnumerator CoinGenerator(){

		yield return new WaitForSeconds (delay);

		if (active) {

			for (int i = 0; i < 5; i++) {

				Instantiate (coins, transform.position + (transform.forward * (10) * i) + transform.up * 2 * -i, 
					Quaternion.identity);
			
			}

		}

		StartCoroutine (CoinGenerator ());
	}
		
}