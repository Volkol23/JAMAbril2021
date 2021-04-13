using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMap : MonoBehaviour
{
    [SerializeField] GameObject lightMap;
    //[SerializeField] Animator animator;
    [SerializeField] GameObject darkMap;


    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
        lightMap = GameObject.FindGameObjectWithTag("Light");
        darkMap = GameObject.FindGameObjectWithTag("Dark");
    }

    // Update is called once per frame
    void Update()
    {
        if(lightMap == null)
        {
            lightMap = GameObject.FindGameObjectWithTag("Light");
        }
        if (darkMap == null)
        {
            darkMap = GameObject.FindGameObjectWithTag("Dark");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Switch_Light();
        }
    }


    public void Switch_Light()
    {
        if (lightMap.activeInHierarchy)
        {
            //animator.SetBool("ChangeToDark", true);
            lightMap.SetActive(false);
            darkMap.SetActive(true);
        }
        else if (darkMap.activeInHierarchy)
        {
            //animator.SetBool("ChangeToDark", false);
            lightMap.SetActive(true);
            darkMap.SetActive(false);
        }
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (lightMap.activeInHierarchy)
        {
            //animator.SetBool("ChangeToDark", true);
            lightMap.SetActive(false);
            darkMap.SetActive(true);
        }
        else if (darkMap.activeInHierarchy)
        {
            //animator.SetBool("ChangeToDark", false);
            lightMap.SetActive(true);
            darkMap.SetActive(false);
        }
    }*/
}
