using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button singlePlayer;
    public Button multiPlayer;
    public Button easyMode;
    public Button normalMode;

    private void Start()
    {
        singlePlayer.gameObject.SetActive(false);
        multiPlayer.gameObject.SetActive(false);
        easyMode.gameObject.SetActive(false);
        normalMode.gameObject.SetActive(false);
    }

    public void SetActive()
    {
        singlePlayer.gameObject.SetActive(true);
        multiPlayer.gameObject.SetActive(true);
        easyMode.gameObject.SetActive(false);
        normalMode.gameObject.SetActive(false);
    }

    public void SetDificulty()
    {
        singlePlayer.gameObject.SetActive(false);
        multiPlayer.gameObject.SetActive(false);
        easyMode.gameObject.SetActive(true);
        normalMode.gameObject.SetActive(true);
    }

    public void LoadMulti()
    {
        SceneManager.LoadScene("conduccion9");
    }

    public void LoadSingle()
    {
        SceneManager.LoadScene("Singleplayer");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
