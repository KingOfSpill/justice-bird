using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinLoader : MonoBehaviour {

    public int coins;

	public void Start ()
    {
        coins = SaveLoad.loadNumberOfCoins();
        gameObject.GetComponent<Text>().text = "X " + coins;

    }

    public void Buy(int cost)
    {
        coins -= cost;
        gameObject.GetComponent<Text>().text = "X " + coins;
        SaveLoad.saveNumberOfCoins(coins);
    } 
	
}
