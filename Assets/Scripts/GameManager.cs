﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public static float Black_points;
    public static float White_points;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        White_points = 0;
        Black_points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetBlackPoints()
    {
        return Black_points;
    }
    public float GetWhitePoints()
    {
        return White_points;
    }
    public void UpdateWhitePoints()
    {
        White_points++;
        Debug.Log(White_points);
    }

    public void UpdateBlackPoints()
    {
        Black_points++;
        Debug.Log(Black_points);
    }
}