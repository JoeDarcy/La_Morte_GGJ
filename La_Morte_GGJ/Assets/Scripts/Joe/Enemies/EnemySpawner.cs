using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int numberOfEnemiesToSpawn;
    [SerializeField] private GameObject enemy1;
    [SerializeField] private GameObject enemy2;

    private Vector3 spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < numberOfEnemiesToSpawn; ++i)
        {
            spawnPoint = new Vector3(Random.Range(-200, 200), 0, Random.Range(-200, 200));
            Instantiate(enemy1, spawnPoint, Quaternion.identity);
            spawnPoint = new Vector3(Random.Range(-200, 200), 0, Random.Range(-200, 200));
            Instantiate(enemy2, spawnPoint, Quaternion.identity);
        }
    }
}
