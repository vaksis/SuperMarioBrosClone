﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    //==========Load new level============
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    //==========Application shutdown============
    public void ClickExit()
    {
        Application.Quit();
    }
}
