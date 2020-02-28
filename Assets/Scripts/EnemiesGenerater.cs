using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesGenerater : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject enemiesFolder;
    private float enemyNumber;
    private string enemyText;

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

            //ランダム時間のたいき
            float waitTime=Random.Range(1f,3f);
            yield return new WaitForSeconds(waitTime);
            //Debug.Log(+ n + "回目待機:" + waitTime + "秒終了");

            //エネミーの数値決定
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0,enemyPrefabs.Length)];
            enemyNumber = Random.Range(0f,5f);
            //enemyText += enemyNumber;

            //エネミーをenemiesFolder下に生成
            GameObject enemy = (GameObject)Instantiate (enemyPrefab,new Vector3(Random.Range(-20f,20f),1,Random.Range(-15f,15f)),Quaternion.identity);
            enemy.transform.parent = enemiesFolder.transform;
            
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