// Script_Harder.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/25
// Description: This script contians difficalty change funciton
// History: None

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Harder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().MakeItHarder();
        }
    }
}
