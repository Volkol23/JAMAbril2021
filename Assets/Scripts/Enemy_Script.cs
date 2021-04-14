﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{

    public float Speed;
    Rigidbody2D Rigidbody2D;
    public int Health = 1;

    public AudioManager audioManager;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = new Vector2(Speed, Rigidbody2D.velocity.y);
        audioManager.PlaySpider();


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            Speed *= -1;
            this.transform.localScale = new Vector2(this.transform.localScale.x * -1, this.transform.localScale.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        
    }
}


