using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
    public GameObject gameController;
    void Start()
    {
        //gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    /*void OnTriggerEnter(Collider other)
    {
        if (TimeManager.restTime == 0)
        {
            lifeController.GameOver();
        }

        else if (ScaleController.lifeNumber >= 10000)
        {
            lifeController.GameOver();
        }
    }*/
}