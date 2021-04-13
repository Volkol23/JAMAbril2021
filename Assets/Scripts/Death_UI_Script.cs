using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_UI_Script : MonoBehaviour
{
    public GameObject Death;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<Player_movment>().Health <= 0) {
            if (Death.activeInHierarchy == false)
            {
                Death.SetActive(true);
                Destroy(Player);
                //or delete sprite render and move script
            }
        }
    }
}
