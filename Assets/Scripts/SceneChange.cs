﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    
    
    // Update is called once per frame
    void Update()
    {

        if (LifeManager.lifePoint<100)
        {
            SceneManager.LoadScene("GameClear");
        }
        if (LifeManager.lifePoint > 999||TimeManager.restTime<=90.0f){

            SceneManager.LoadScene("gameover");
        }
    }
}