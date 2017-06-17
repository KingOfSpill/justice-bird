using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {

    public GameObject pauseScreen;
    private bool isPaused = false;

    // Use this for initialization
    void Start () {

        // Make the pause screen invisible when the level loads
        pauseScreen.SetActive(isPaused);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("escape"))
        {

            isPaused = !isPaused;

            // Set the pause screen visibility and set the timeu scale
            pauseScreen.SetActive(isPaused);
            Time.timeScale = (isPaused) ? 0.0f : 1.0f;

        }

    }
}
