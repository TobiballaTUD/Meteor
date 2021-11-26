using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] meteorPrefabs; 

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomMeteor", 1, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomMeteor()
    {
        Instantiate(meteorPrefabs[0], new Vector3(Random.Range(-100, 100), 0, 100), meteorPrefabs[0].transform.rotation);

    }
}
