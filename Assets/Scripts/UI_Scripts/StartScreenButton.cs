using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Event for the start screen
    public void OnButtonPressed()
    {
        Debug.Log("Start screen pressed.");
        SceneManager.LoadScene("Lvl_Game");
    }
}
