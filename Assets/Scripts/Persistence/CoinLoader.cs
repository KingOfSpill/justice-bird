﻿using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.UI;  public class CoinLoader : MonoBehaviour {      	void Start ()     {          Text coins = gameObject.GetComponent<Text>();         coins.text = "X " + SaveLoad.loadNumberOfCoins();  	} 	 } 