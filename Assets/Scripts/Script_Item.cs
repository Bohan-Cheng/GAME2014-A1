// Script_Item.cs
// Student Name: Bohan Cheng
// Student #: 101130599
// Last Modified: 2020/10/25
// Description: This script handlles all types of items, and decide what to do with the item
// History: Implemented new method of plying sound clips

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Item : MonoBehaviour
{
    public bool Coin;
    public bool Heart;

    private void Start()
    {
        transform.position = new Vector2(Random.Range(-2.0f, 2.0f), transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            DoStuff(collision);
        }
    }

    public void DoStuff(Collider2D col)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (Coin)
        {
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().AddScore(10);
            player.GetComponent<AudioSource>().PlayOneShot(player.GetComponent<Script_PlayerMovement>().PickupCoin);
        }
        if (Heart)
        {
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().AddLife();
            player.GetComponent<AudioSource>().PlayOneShot(player.GetComponent<Script_PlayerMovement>().PickupHeart);
        }
        gameObject.SetActive(false);
    }
}
