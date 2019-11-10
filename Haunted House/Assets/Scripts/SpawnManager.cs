using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRangeX = 75;
    private float spawnRangeZ = 85;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, new Vector3(0,0,0), enemyPrefab.transform.rotation);
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
