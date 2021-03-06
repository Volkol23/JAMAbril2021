using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_movment : MonoBehaviour
{
    public float ground_distance;

    public float Speed;
    public float JumpForce;
    

    Rigidbody2D Rigidbody2D;
    public float horizontal;



    public Animator animator;
    public bool in_ground;


    public int Health = 1;
   

    public bool isDead;

    public AudioManager audioManager;
    private bool acceptInputs;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        acceptInputs = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(acceptInputs) horizontal = Input.GetAxisRaw("Horizontal");

        //flip body
        if (horizontal < 0.0f && acceptInputs) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (horizontal > 0.0f && acceptInputs) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);



        
        if (Physics2D.Raycast(transform.position+new Vector3(0,0,0), Vector3.down, ground_distance))
        {
           in_ground = true;
        }
        else in_ground = false;



        if (Input.GetKeyDown("space") && in_ground && acceptInputs)
        {
            Jump();
        }

        if (Input.GetKeyDown("r") && acceptInputs)
        {
            Hit();
        }

        if (Health <= 0)
        {
            audioManager.PlayDeath();
            GameManager.instance.GoToCheckpointPos();
            //GameManager.instance.RssetPoints();
            //SceneManager.LoadScene("Level");
            transform.position = GameManager.instance.GetCheckpointPos();
            Health = 1;
        }


       
        animator.SetFloat("Speed", Mathf.Abs(horizontal));
        animator.SetBool("Grounded", in_ground);
    }

    private void Jump()
    {

        Rigidbody2D.AddForce(transform.up * JumpForce);

    }

    public void Move()
    {
        acceptInputs = true;
    }
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(horizontal * Speed, Rigidbody2D.velocity.y);
    }

    //para estarse en la posicion 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (!in_ground) Destroy(collision.gameObject);
            else Hit();
        }
        if (collision.gameObject.tag == "Plataforma")
        {
            if(GameManager.instance.GetComponent<ChangeMap>().GetMapLevel() < 0)
                gameObject.transform.parent = collision.transform;
        }
        
        
    }
    
    public void Hit()
    {
        audioManager.PlayHit();
        Health -= 1;
        //if (Health <= 0)
        //{
            //SceneManager.LoadScene("Prueba");
        //}
    }
    
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plataforma")
        {
            transform.parent = null;
        }
    }
    
}

