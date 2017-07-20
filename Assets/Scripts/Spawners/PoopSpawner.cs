using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoopSpawner : MonoBehaviour {

    public AudioClip fart;
    private AudioSource source;

    public GameObject poop;
    public UIscript ui;

    void Start()
    {
        source = this.gameObject.AddComponent<AudioSource>();
        source.clip = fart;
    }

    void Update ()
    {
        if (Input.GetKeyDown("space"))
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