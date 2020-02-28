using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public AudioClip sound;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        //衝突判定
        if (collision.gameObject.tag == "Player" )
        {


                AudioSource.PlayClipAtPoint(sound, transform.position);
            
            //相手のタグがBallならば、自分を消す
            Destroy(this.gameObject);
        }
    }
}
