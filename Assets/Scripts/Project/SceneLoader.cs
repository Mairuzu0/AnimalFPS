﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    int currentScene;

    private void Awake()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene(currentScene);
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadSettings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Sandbox");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Arctic");
    }

}