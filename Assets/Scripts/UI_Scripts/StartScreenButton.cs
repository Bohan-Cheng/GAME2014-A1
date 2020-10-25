// StartScreenButton.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/25
// Description: This script cointians functionalities for buttons in menu screen
// History: Added button to How to Play scene and added back button

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
