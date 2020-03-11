using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Onclick()
    {
        
       /*TimeManager.restTime += Time.time;
        Debug.Log(TimeManager.restTime);*/

        SceneManager.LoadScene("Main");
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }

     
}
