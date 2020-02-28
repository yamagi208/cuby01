using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{
    GameObject scoreText;
    GameObject gameClearText;

    public static int lifeNumber = 100;
    // Start is called before the first frame update
    public int ScaleChange()
    {
        lifeNumber -= 10;


        return lifeNumber;
        
    }

    public void GameClear()
    {
          //this.gameClearText.GetComponent<Text>().text = "GameClear";
    }
    void Start()
    {
        this.scoreText = GameObject.Find("Life");
        //this.gameClearText = GameObject.Find("GameClear");
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.GetComponent<Text>().text = lifeNumber.ToString("D3"); 
       if(lifeNumber <= 0)
        {
            GameClear();
        }
    }
}
