using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] meteorPrefabs;
    private float spawnRangeX = 100;
    private float spawnPositionY = 100;

    void Start()
    {
        InvokeRepeating("SpawnRandomMeteor", 1, 0.5f);
    }

    void Update()
    {
        
    }

    void SpawnRandomMeteor()
    {
        Instantiate(meteorPrefabs[0], new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionY), meteorPrefabs[0].transform.rotation);

    }
}
