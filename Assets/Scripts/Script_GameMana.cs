// Script_GameMana.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/25
// Description: This script handles the UI update and level difficalties
// History: Added make it harder function

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_GameMana : MonoBehaviour
{
    public GameObject LivesObj;
    public GameObject ScoreObj;
    public int Lives = 3;
    public int Score = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddLife()
    {
        if(Lives < 3)
        {
            Lives++;
            UpdateUI();
        }
    }
    public void RemoveLife()
    {
        if(Lives > 0)
        {
            Lives--;
            UpdateUI();
        }
        if(Lives == 0)
        {
            SceneManager.LoadScene("Lvl_Game02");
        }
    }
    public void AddScore(int score)
    {
        Score += score;
        UpdateUI();
    }

    void UpdateUI()
    {
        LivesObj.GetComponent<TextMeshProUGUI>().SetText("Lives: {0}", Lives);
        ScoreObj.GetComponent<TextMeshProUGUI>().SetText("Score: {0}", Score);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("TEST");
        if(scene.name == "Lvl_Game02")
        {
            GameObject.FindGameObjectWithTag("EndScore").GetComponent<TextMeshProUGUI>().SetText("Score: {0}", Score);
        }
        if(scene.name == "Lvl_Start")
        {
            Lives = 3;
            Score = 0;
        }
    }

    public void MakeItHarder()
    {
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Map"))
        {
            g.GetComponent<Script_MapScroll>().verticalSpeed *= 1.5f;
        }
    }
}
