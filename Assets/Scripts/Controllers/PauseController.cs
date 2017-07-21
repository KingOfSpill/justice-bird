using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour {

    public GameObject pauseScreen;
    public bool isPaused = false;

    // Use this for initialization
    public void Start ()
    {

        // Make the pause screen invisible when the level loads
        pauseScreen.SetActive(isPaused);

    }
	
	// Update is called once per frame
	public void Update ()
    {

        if (Input.GetKeyDown("escape"))
            switchPause();

    }

    public void switchPause( )
    {

        isPaused = !isPaused;

        // Set the pause screen visibility and set the timeu scale
        pauseScreen.SetActive(isPaused);
        Time.timeScale = (isPaused) ? 0.0f : 1.0f;

    }
}
