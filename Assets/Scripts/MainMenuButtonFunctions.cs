﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonFunctions : MonoBehaviour {

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
