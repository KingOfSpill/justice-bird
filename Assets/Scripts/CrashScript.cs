using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashScript : MonoBehaviour {

    public GameObject deadScreen;

    //Make Sure it isn't active
    void Start()
    {
        deadScreen.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Building") || other.gameObject.CompareTag("NPC"))
        {
            deadScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
