using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoopSpawner : MonoBehaviour {

    public AudioClip fart;
    private AudioSource source;

    public GameObject poop;
    public UIscript ui;

    public void Start()
    {
        source = this.gameObject.AddComponent<AudioSource>();
        source.clip = fart;
        poop = Resources.LoadAll<GameObject>("PoopSkins")[SaveLoad.loadCurrentPoopSkin()];
    }

    public void Update ()
    {
        if (Input.GetKeyDown("space") & Time.timeScale != 0.0f)
            spawnPoop();
    }

    public GameObject spawnPoop()
    {
        if (ui.bowelMovement())
        {
            source.Play();
            return Instantiate(poop, transform.position, transform.rotation, transform.parent);
        }
        else
            return null;
    }

}