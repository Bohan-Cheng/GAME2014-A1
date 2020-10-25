using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_MapScroll : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(0.0f, 39.0f);
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
            child.position = new Vector2(Random.Range(-2.5f, 2.5f), child.position.y);
        }
    }

    private void _Move()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.y <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
