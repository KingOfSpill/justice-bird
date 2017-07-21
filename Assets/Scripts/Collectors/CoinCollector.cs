using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour {

	public UIscript ui;
    
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {
            DestroyCoin(other.gameObject);
            Destroy(other.gameObject);
        }

	}

    public void DestroyCoin(GameObject other)
    {

        other.SetActive(false);
        ui.getCoin();

    }

}