using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;

public class Script_PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float MoveSpeed = 3.0f;

    Animator anim;
    public GameObject Tongue;

    bool CanFire = true;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveAndAttack();
    }

    void MoveAndAttack()
    {
        foreach (var touch in Input.touches)
        {
            var worldTouch = Camera.main.ScreenToWorldPoint(touch.position);
            bool right = worldTouch.x > 0.0f && transform.position.x < 2.5f;
            bool left = worldTouch.x < -0.0f && transform.position.x > -2.5f;
            bool fire = worldTouch.y > -3.0f;


            // Move right
            if (right && !fire)
            {
                transform.Translate(MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
            }

            // Move left
            if(left && !fire)
            {
                transform.Translate(-MoveSpeed * Time.deltaTime, 0.0f, 0.0f);
            }

            if(fire && CanFire)
            {
                CanFire = false;
                anim.SetTrigger("Fire");
                Tongue.SetActive(true);
                Invoke("DelayStopFire", 0.5f);
                Invoke("DelayCanFire", 1.0f);
            }
        }
    }

    void DelayStopFire()
    {
        Tongue.SetActive(false);
    }

    void DelayCanFire()
    {
        CanFire = true;
    }
}
