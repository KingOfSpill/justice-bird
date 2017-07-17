using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoopSpawner : MonoBehaviour {

    public float speed;
    public float tilt;

    public AudioClip fart;
    private AudioSource source;

    public GameObject Poop;
    public UIscript ui;
    public float fireRate;

    private float nextFire;

    void Start()
    {
        source = this.gameObject.AddComponent<AudioSource>();
        source.clip = fart;
    }

    void Update ()
    {
        if ((Input.GetButton("Fire1") || Input.GetKeyDown("space")))
            spawnPoop();
    }

    public GameObject spawnPoop()
    {
        if (ui.bowelMovement())
        {
            source.Play();
            return Instantiate(Poop, transform.position, transform.rotation, transform.parent);
        }
        else
            return null;
    }

    public void test()
    {
        return;
    }

}