using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public float Speed;
    Rigidbody2D Rigidbody2D;
    private float Speed_;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = new Vector2(Speed, Rigidbody2D.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            Speed *= -1;
            
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.parent = transform;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Player_movment>().Speed= Speed_;
    }
}
