using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(-0.2f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(0.2f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.Translate(0.0f, 0.0f, 0.2f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Translate(0.0f, 0.0f, -0.2f);
        }
    }
}
