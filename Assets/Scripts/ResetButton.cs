using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Onclick()
    {
        //TimeManager.restTime += Time.time;
        SceneManager.LoadScene("GameStart");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
