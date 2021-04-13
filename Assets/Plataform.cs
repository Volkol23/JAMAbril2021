using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public float Speed;
    Rigidbody2D Rigidbody2D;
    public Transform target;

    private Transform startPos;
    private bool move;


    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        startPos = transform;
        move = true;
    }

    // Update is called once per frame
    void Update()
    {
        float step = Speed * Time.deltaTime;
        if (transform.position == target.position)
        {
            move = false;
        }
        else if (transform == startPos)
        {
            move = true;
        }
        if (move == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos.position, step);
        }
        else if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            Speed *= -1;

        }
    }
   
}
