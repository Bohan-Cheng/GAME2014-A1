using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Tongue : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            collision.gameObject.SetActive(false);
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().AddScore(15);
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<AudioSource>().PlayOneShot(player.GetComponent<Script_PlayerMovement>().KilledEnemy);
        }
        
        if(collision.tag == "Item")
        {
            collision.GetComponent<Script_Item>().DoStuff(GetComponent<BoxCollider2D>());
        }
    }
}
