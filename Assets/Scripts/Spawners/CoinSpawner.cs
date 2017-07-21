using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject coin;

    public GameObject CreateCoin ()
    {

        return Instantiate(coin, transform.position, transform.rotation * Quaternion.Euler(90, 0, 0));
       
    }
	
}
