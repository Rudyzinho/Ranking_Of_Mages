using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints;
    [SerializeField]
    private GameObject[] enemyPrefabs;
    private int randomSpawnPoint;
    private int randomEnemy;


    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, 1f);
    }

    void SpawnEnemy()
    {
        //get random spawn point
        randomSpawnPoint = Random.Range(0, spawnPoints.Length);

        randomEnemy = Random.Range(0, enemyPrefabs.Length);

        Instantiate(enemyPrefabs[randomEnemy], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
    }

    
}
