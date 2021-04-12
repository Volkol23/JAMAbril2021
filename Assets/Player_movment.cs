using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_movment : MonoBehaviour
{


    public float Black_points;
    public float White_points;
    public float ground_distance;

    public float Speed;
    public float JumpForce;
    

    Rigidbody2D Rigidbody2D;
    public float horizontal;

    


    public bool in_ground;


    public int Health = 1;
   

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
     
        horizontal = Input.GetAxisRaw("Horizontal");

        //flip body
        if (horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);



        
        if (Physics2D.Raycast(transform.position+new Vector3(0,0,0), Vector3.down, ground_distance))
        {
           in_ground = true;
        }
        else in_ground = false;



        if (Input.GetKeyDown("space") && in_ground)
        {
            Jump();
        }

        if (Input.GetKeyDown("r"))
        {
            Hit();
        }

        if (Health <= 0)
        {

        }

      
     

    }
    private void Jump()
    {

        Rigidbody2D.AddForce(transform.up * JumpForce);

    }


    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(horizontal * Speed, Rigidbody2D.velocity.y);
    }

    //para estarse en la posicion 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
       
    }
    public void Hit()
    {
        Health -= 1;
    }
   
}

