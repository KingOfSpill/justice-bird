using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashScript : MonoBehaviour {

    public GameObject deadScreen;

    //Make Sure it isn't active
    public void Start()
    {
        deadScreen.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Building") || other.gameObject.CompareTag("NPC") || other.gameObject.CompareTag("Obstacle"))
        {
            deadScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
