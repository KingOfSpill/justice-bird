using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoad {

    public static void saveCurrentPoopSkin(int skin)
    {
        PlayerData playerData = load();
        playerData.poopSkin = skin;
        save(playerData);
    }

    public static int loadCurrentPoopSkin()
    {
        return load().poopSkin;
    }

    public static void savePoopSkinsUnlocked(List<bool> unlocked)
    {
        PlayerData playerData = load();
        playerData.poopSkinsUnlocked = unlocked;
        save(playerData);
    }

    public static List<bool> loadPoopSkinsUnlocked()
    {

        return load().poopSkinsUnlocked;

    }

    public static void saveCurrentBirdSkin(int skin)
    {
        PlayerData playerData = load();
        playerData.birdSkin = skin;
        save(playerData);
    }

    public static int loadCurrentBirdSkin()
    {
        return load().birdSkin;
    }

    public static void saveBirdSkinsUnlocked(List<bool> unlocked)
    {
        PlayerData playerData = load();
        playerData.birdSkinsUnlocked = unlocked;
        save(playerData);
    }

    public static List<bool> loadBirdSkinsUnlocked()
    {

        return load().birdSkinsUnlocked;

    }

    public static void saveNumberOfCoins(int numCoins)
    {
        PlayerData playerData = load();

        playerData.totalCoins = numCoins;

        save(playerData);

    }

    public static int loadNumberOfCoins()
    {

        return load().totalCoins;

    }

    public static void save(PlayerData data)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/userdata.dat", FileMode.OpenOrCreate);

        binaryFormatter.Serialize(file, data);
        file.Close();
    }

    public static PlayerData load()
    {

        string filePath = Application.persistentDataPath + "/userdata.dat";

        if(File.Exists(filePath))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(filePath, FileMode.Open);

            PlayerData data = (PlayerData)binaryFormatter.Deserialize(file);

            file.Close();

            return data;
        }

        return new PlayerData();

    }

}
