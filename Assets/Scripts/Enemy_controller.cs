using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_controller : MonoBehaviour
{
    public int ball_number = 0;
    float fallSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
        this.fallSpeed = 0.1f;
        this.ball_number = (int)Random.Range (1.0f, 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
         transform.Translate(0, -fallSpeed, 0, Space.World);
    }
}
