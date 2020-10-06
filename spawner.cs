using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject pointPrefab;
    public GameObject enemyPrefab2;
    public GameObject pointPrefab2;
    public Vector3 s1;
    public Vector3 s2;
    public float respawnTime = 2.00f;
    
    void Start () 
    {
    
    
            StartCoroutine(asteroidWave());
    
    }
    private void spawnEnemy(){
        if(Random.Range(0,2)>=1)
        {
            if(Random.Range(0,2)>=1){
                GameObject a = Instantiate(enemyPrefab) as GameObject;
                a.transform.position = new Vector3(50,s1.y,s1.z);
            }
            else
            {
                GameObject b = Instantiate(enemyPrefab) as GameObject;
                b.transform.position = new Vector3(50,s2.y,s2.z);
            }


        }
        else
        {
            if(Random.Range(0,2)>=1){
                GameObject a = Instantiate(pointPrefab) as GameObject;
                a.transform.position = new Vector3(50,s1.y,s1.z);
            }
            else
            {
                GameObject b = Instantiate(pointPrefab) as GameObject;
                b.transform.position = new Vector3(50,s2.y,s2.z);
            }
        }
        if(Random.Range(0,2)>=1)
        {
            if(Random.Range(0,2)>=1){
                GameObject a = Instantiate(enemyPrefab2) as GameObject;
                a.transform.position = new Vector3(50,s1.y,-s1.z);
            }
            else
            {
                GameObject b = Instantiate(enemyPrefab2) as GameObject;
                b.transform.position = new Vector3(50,s2.y,-s2.z);
            }

        }
        else
        {
            if(Random.Range(0,2)>=1){
                GameObject a = Instantiate(pointPrefab2) as GameObject;
                a.transform.position = new Vector3(50,s1.y,-s1.z);
            }
            else
            {
                GameObject b = Instantiate(pointPrefab2) as GameObject;
                b.transform.position = new Vector3(50,s2.y,-s2.z);
            }
        }
    }
    IEnumerator asteroidWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}