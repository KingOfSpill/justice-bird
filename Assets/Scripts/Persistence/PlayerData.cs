using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;

[System.Serializable]
public class PlayerData {

    public int totalCoins = 0;

    public PlayerData()
    {
    }

    public PlayerData(int coins)
    {
        totalCoins = coins;
    }

}
