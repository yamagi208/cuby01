using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text displayTime;
    public float restTime; 

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        restTime = 100f - Time.time;
        displayTime.text = "残り時間(秒):" + restTime ;
    }
}