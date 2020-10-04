using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButton : MonoBehaviour
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
    public void OnMenuButtonPressed()
    {
        Debug.Log("Menu button pressed.");
        SceneManager.LoadScene("Lvl_Start");
    }

    public void OnNextButtonPressed()
    {
        Debug.Log("Next button pressed.");
        SceneManager.LoadScene("Lvl_Game02");
    }
}
