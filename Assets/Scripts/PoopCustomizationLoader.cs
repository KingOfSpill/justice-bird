﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoopCustomizationLoader : MonoBehaviour {
    public string folder;
    public GameObject[] prefabs;
    public GameObject customizationOption;
    public List<GameObject> spawned;
    public List<bool> unlocked;
    public CoinLoader coins;

	// Use this for initialization
	public void Start () {

        loadResources(folder);
        setPanelSize();
        spawnItems();       
		
	}

    public void spawnItems()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            spawned.Add(Instantiate(customizationOption, transform));

            GameObject newPoop = Instantiate(prefabs[i], spawned[i].transform.GetChild(spawned[i].transform.childCount - 1).transform);
            newPoop.GetComponent<PoopController>().fallSpeed = 0;

            spawned[i].GetComponent<RectTransform>().localPosition = new Vector3((30f * i) - (15f * (prefabs.Length-1)), 0, 1);

            if (unlocked[i])
                setLock(i, false);

            int index = i;

            spawned[i].GetComponent<Button>().onClick.AddListener(() => pressOption(index));

        }
    }

    public void setPanelSize()
    {
        RectTransform transform = gameObject.GetComponent<RectTransform>();

        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, prefabs.Length * 30f);
    }

    public void pressOption(int i)
    {

        if( !unlocked[i] && coins.coins >= 100)
        {
            coins.Buy(100);
            unlocked[i] = true;

            SaveLoad.savePoopSkinsUnlocked(unlocked);

            setLock(i, false);

        }
        else if (unlocked[i])
        {
            setCurrentSkin(i);
        }

    }

    public void setCurrentSkin(int i)
    {
        SaveLoad.saveCurrentPoopSkin(i);
    }

    public void setLock( int i, bool locked)
    {
        foreach (RawImage img in spawned[i].GetComponentsInChildren<RawImage>())
        {
            if (img.gameObject.name == "LockIcon")
                img.gameObject.SetActive(locked);
        }
    }

    public void loadResources(string folder)
    {

        prefabs = Resources.LoadAll<GameObject>(folder);

        unlocked = SaveLoad.loadPoopSkinsUnlocked();

        while (unlocked.Count < prefabs.Length)
            unlocked.Add(false);

    }
}
