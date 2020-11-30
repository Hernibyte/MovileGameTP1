﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button singlePlayer;
    public Button multiPlayer;

    private void Start()
    {
        singlePlayer.gameObject.SetActive(false);
        multiPlayer.gameObject.SetActive(false);
    }

    public void SetActive()
    {
        singlePlayer.gameObject.SetActive(true);
        multiPlayer.gameObject.SetActive(true);
    }

    public void LoadSingle()
    {
        SceneManager.LoadScene("conduccion9");
    }

    public void LoadMulti()
    {
        SceneManager.LoadScene("conduccionAlone");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
