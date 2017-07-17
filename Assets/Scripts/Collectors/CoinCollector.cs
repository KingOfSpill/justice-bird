using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour {

	public UIscript ui;
    
    void OnTriggerEnter(Collider other)
    {

		if (other.gameObject.CompareTag("Coin"))
        {

            other.gameObject.SetActive(false);
			Destroy(other.gameObject);
			ui.getCoin ();

		}

	}

}