﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
