using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pincho_Down : MonoBehaviour
{
    Rigidbody2D Rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Player_movment>().Health -= 1;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {


            GetComponent<Rigidbody2D>().bodyType -= 2;
        }
    }
}
