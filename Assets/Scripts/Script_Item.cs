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
        if (Coin)
        {
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().AddScore(10);
            col.GetComponent<AudioSource>().PlayOneShot(col.GetComponent<AudioSource>().clip);
        }
        if (Heart)
        {
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().AddLife();
        }
        gameObject.SetActive(false);
    }
}
