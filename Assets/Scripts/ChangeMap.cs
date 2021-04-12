﻿using System.Collections;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
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
}
