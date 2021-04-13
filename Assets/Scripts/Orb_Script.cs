using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb_Script : MonoBehaviour
{

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("+1 point");
        if (collision.gameObject.tag.Equals("Player")){
            
            if (gameObject.tag.Equals("Black"))
            {
                GameManager.instance.UpdateBlackPoints();
                Destroy(gameObject);
            }
            if (gameObject.tag.Equals("White"))
            {
                GameManager.instance.UpdateWhitePoints();
                Destroy(gameObject);

            }
        }
    }
}
