using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Spawner : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    public int objectIndex;

    private float spawnRangeX = 8;
    private float spawnRangeY = 20;
    private float startDelay = 1;
    private float spawnInterval = 1.3f;



    void Start()
    {
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);

    }

    public void SpawnRandomObject()
    {
        int objectIndex = Random.Range(0, objectPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY, 0);
        Instantiate(objectPrefabs[objectIndex], spawnPos, objectPrefabs[objectIndex].transform.rotation);
    }
}