using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesGenerater : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject enemiesFolder;
    static int enemyNumber;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("EnemyGenerate");
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator EnemyGenerate()
    {
        for(int n = 1;n != 0; n++ )
        {
            //Debug.Log(+ n + "回目開始");

            //ランダム時間の待機
            float waitTime=Random.Range(1f,3f);
            yield return new WaitForSeconds(waitTime);
            //Debug.Log(+ n + "回目待機:" + waitTime + "秒終了");

            //エネミーをenemiesFolder下に生成
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0,enemyPrefabs.Length)];
            GameObject enemy = (GameObject)Instantiate (enemyPrefab,new Vector3(Random.Range(-20f,20f),1,Random.Range(-15f,15f)),Quaternion.identity);
            enemy.transform.parent = enemiesFolder.transform;
            
            //エネミーの数値決定
            enemyNumber = Random.Range(0,6);
            enemy.transform.Find("Canvas").Find("EnemyNumber").gameObject.GetComponent<Text>().text = "" + enemyNumber;

            /*To成宮
            生成したenemy下にint型のenemyNumberで数値を与えて流から、enemyNumberを取得すれば大丈夫なはず。加減乗除は与えてないので接触する敵から判断するようにしてほしい。
            */
            Debug.Log(enemyNumber);
            
            //エネミーにランダム方向に力を加える
            Rigidbody enemyRigidbody = enemy.GetComponent<Rigidbody>();
            enemyRigidbody.AddForce(new Vector3(Random.Range(-10f,10f),0,Random.Range(-10f,10f)) , ForceMode.VelocityChange);

            if(n==5)
            {
                //Debug.Log("コルーチン終了");
                yield break;
            }
        }        
    }
}