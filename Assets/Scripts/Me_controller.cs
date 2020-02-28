using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me_controller : MonoBehaviour
{
    public float scaleFunction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider coll){
        Destroy (coll.gameObject);   
        PlayerScale(GameObject.Find ("GameController").GetComponent<ScaleController> ().ScaleChange());
    }


    public float PlayerScaleFunction(int number)
    {
         float playerScale = 0;

        playerScale =  (float)Mathf.Sqrt(number);

        return playerScale;


    }
    public void PlayerScale(int playerScale)
    {
        this.transform.localScale = new Vector3((float)(scaleFunction *0.1 * playerScale), (float)(scaleFunction*0.1 * playerScale), (float)(scaleFunction*0.1 * playerScale));
    }
}
