using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] float direction;
    [SerializeField] bool horizontal;
    [SerializeField] bool vertical;

    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (horizontal)
        {
            rigidbody.velocity = new Vector2(direction * speed, rigidbody.velocity.y);
        }
        else if (vertical)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, direction * speed);
        }
    }
}
