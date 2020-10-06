using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner3 : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector3 s1;
    public Vector3 s2;
    public float respawnTime = 2.00f;
    
    void Start () 
    {
    
    
        StartCoroutine(asteroidWave());
    
    }
    private void spawnEnemy(){
    
                GameObject a = Instantiate(enemyPrefab) as GameObject;
                a.transform.position = new Vector3(50,s1.y,s1.z);
                GameObject b = Instantiate(enemyPrefab) as GameObject;
                b.transform.position = new Vector3(50,s2.y,s2.z);
                
    }
    
    IEnumerator asteroidWave() {
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}