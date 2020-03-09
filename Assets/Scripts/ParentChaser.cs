using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentChaser : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        Vector3 myPosition;
        Vector3 myRotation;

        myPosition.x = myTransform.parent.position.x;
        myPosition.y = myTransform.position.y;
        myPosition.z = myTransform.parent.position.z;
        myTransform.position = myPosition;

        myRotation.x = 90f;
        myRotation.y = 0f;
        myRotation.z = 0f;
        myTransform.eulerAngles = myRotation;
    }
}
