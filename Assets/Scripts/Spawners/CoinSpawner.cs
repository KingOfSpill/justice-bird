using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject coin;

    public void CreateCoin ()
    {

        Instantiate(coin, transform.position, transform.rotation * Quaternion.Euler(90, 0, 0));
       
    }
	
}
