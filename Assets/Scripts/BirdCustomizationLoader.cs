﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdCustomizationLoader : MonoBehaviour {

    public string folder;
    public Material[] materials;
    public GameObject customizationOption;
    public List<GameObject> spawned;
    public List<bool> unlocked;
    public CoinLoader coins;
    
	public void Start () {

        loadResources(folder);
        setPanelSize();
        spawnItems();       
		
	}

    public void spawnItems()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            spawned.Add(Instantiate(customizationOption, transform));
            spawned[i].GetComponentInChildren<Renderer>().material = materials[i];
            spawned[i].GetComponent<RectTransform>().localPosition = new Vector3((30f * i) - (15f * (materials.Length-1)), 0, 1);

            if (unlocked[i])
                setLock(i, false);

            int index = i;

            spawned[i].GetComponent<Button>().onClick.AddListener(() => pressOption(index));

        }
    }

    public void setPanelSize()
    {
        RectTransform transform = gameObject.GetComponent<RectTransform>();

        transform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, materials.Length * 30f);
    }

    public void pressOption(int i)
    {

        if( !unlocked[i] && coins.coins >= 100)
        {
            coins.Buy(100);
            unlocked[i] = true;

            SaveLoad.saveBirdSkinsUnlocked(unlocked);

            setLock(i, false);

        }
        else if (unlocked[i])
        {
            SaveLoad.saveCurrentBirdSkin(i);
        }

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

        materials = Resources.LoadAll<Material>(folder);

        unlocked = SaveLoad.loadBirdSkinsUnlocked();

        while (unlocked.Count < materials.Length)
            unlocked.Add(false);

    }
}
