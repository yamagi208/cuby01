using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesGenerater : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject enemiesFolder;
    static int enemyNumber;

    public float minWaitTime,maxWaitTime,minSpeedX,maxSpeedX,minSpeedZ,maxSpeedZ;
    public int minEnemyNumber,maxEnemyNumber;

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
            //ランダム時間の待機
            float waitTime=Random.Range(minWaitTime,maxWaitTime);
            yield return new WaitForSeconds(waitTime);

            //エネミーをenemiesFolder下に生成
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0,enemyPrefabs.Length)];
            GameObject enemy = (GameObject)Instantiate (enemyPrefab,new Vector3(Random.Range(-20f,20f),1,Random.Range(-15f,15f)),Quaternion.identity);
            enemy.transform.parent = enemiesFolder.transform;
            
            //エネミーの数値決定
            enemyNumber = Random.Range(minEnemyNumber,maxEnemyNumber);
            enemy.transform.Find("Canvas").Find("EnemyNumber").gameObject.GetComponent<Text>().text = "" + enemyNumber;
            
            //エネミーにランダム方向に力を加える
            Rigidbody enemyRigidbody = enemy.GetComponent<Rigidbody>();
            enemyRigidbody.AddForce(new Vector3(Random.Range(minSpeedX,maxSpeedX),0,Random.Range(minSpeedZ,maxSpeedZ)) , ForceMode.VelocityChange);

            //何かしらの条件を満たしたら敵の生成を終了
            if(n==5)
            {
                yield break;
            }
        }        
    }
}