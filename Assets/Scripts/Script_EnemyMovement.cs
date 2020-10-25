using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_EnemyMovement : MonoBehaviour
{
    float horizontalSpeed;
    float horizontalBoundary;
    float direction;

    void Start()
    {
        SetRandomSpeed();
    }

    void SetRandomSpeed()
    {
        horizontalSpeed = Random.Range(2.0f, 5.0f);
        horizontalBoundary = Random.Range(0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
            SetRandomSpeed();
        }

        // check left boundary
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
            SetRandomSpeed();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("GameMana").GetComponent<Script_GameMana>().RemoveLife();
        }
    }
}
