// Script_SceneMana.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/25
// Description: This script decides what to happen when a scene is loaded
// History: None

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_SceneMana : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Lvl_Game02")
        {
            GameObject.FindGameObjectWithTag("EndScore").GetComponent<TextMeshProUGUI>().SetText("Score: {0}", GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().Score);
            Destroy(GameObject.FindGameObjectWithTag("GameMana"));
        }
    }
}
