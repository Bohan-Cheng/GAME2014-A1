using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenButton : MonoBehaviour
{
    // Event for the start screen
    public void OnStartButtonPressed()
    {
        Debug.Log("Start screen pressed.");
        SceneManager.LoadScene("Lvl_Game");
    }

    public void OnHTPButtonPressed()
    {
        Debug.Log("HTP screen pressed.");
        SceneManager.LoadScene("Lvl_HTP");
    }

    public void OnBackButtonPressed()
    {
        Debug.Log("Back screen pressed.");
        SceneManager.LoadScene("Lvl_Start");
    }
}
