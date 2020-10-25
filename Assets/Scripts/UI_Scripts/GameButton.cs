// GameButton.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/25
// Description: This script cointians functionalities for buttons (End screen)
// History: Removed Debug button to next lvl

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButton : MonoBehaviour
{
    // Event for the start screen
    public void OnMenuButtonPressed()
    {
        Debug.Log("Menu button pressed.");
        SceneManager.LoadScene("Lvl_Start");
    }
}
