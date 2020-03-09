using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{

    public Text lifetext;
    public static int lifePoint = 100;
    //public GameObject life_object = null;
    // Start is called before the first frame update

    void Start()
    {

    }



    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "plus")
        {
            lifePoint += int.Parse(collision.gameObject.transform.Find("Canvas").Find("EnemyNumber").gameObject.GetComponent<Text>().text);
        }
        else if (collision.gameObject.tag == "minus")
        {
            lifePoint -= int.Parse(collision.gameObject.transform.Find("Canvas").Find("EnemyNumber").gameObject.GetComponent<Text>().text);
        }
        else if (collision.gameObject.tag == "divid")
        {
            if (int.Parse(collision.gameObject.transform.Find("Canvas").Find("EnemyNumber").gameObject.GetComponent<Text>().text) != 0)
            {
                lifePoint = lifePoint / int.Parse(collision.gameObject.transform.Find("Canvas").Find("EnemyNumber").gameObject.GetComponent<Text>().text);
            }
        }
        else if (collision.gameObject.tag == "multipl")
        {
            lifePoint *= int.Parse(collision.gameObject.transform.Find("Canvas").Find("EnemyNumber").gameObject.GetComponent<Text>().text);
        }

        //Text lifetext = life_object.GetComponent<Text>();

        lifetext.text = "" + lifePoint;
    }


}
