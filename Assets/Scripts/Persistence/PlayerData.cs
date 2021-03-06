using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;

[System.Serializable]
public class PlayerData {

    public int birdSkin;
    public int poopSkin;
    public int totalCoins;
    public List<bool> birdSkinsUnlocked;
    public List<bool> poopSkinsUnlocked;

    public PlayerData()
    {
        birdSkin = 0;
        poopSkin = 0;
        totalCoins = 0;
        birdSkinsUnlocked = new List<bool>();
        birdSkinsUnlocked.Add(true);
        poopSkinsUnlocked = new List<bool>();
        poopSkinsUnlocked.Add(true);
    }

    public PlayerData(int coins) : this()
    {
        totalCoins = coins;
    }

}
