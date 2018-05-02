using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public Boolean passLevel = false;
    public int score = 0;
    public static GameController instance;

    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (passLevel == true)
        {
            SceneManager.LoadScene("Scene2");
        }

    }
}
