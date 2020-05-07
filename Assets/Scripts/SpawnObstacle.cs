using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public bool canSpawn;

    public static SpawnObstacle Instance;
    public float timeBetweenSpawns;
    public GameObject obstaclePrefab;
    public List<Transform> spawnPositions = new List<Transform>();

    void Start()
    {
        canSpawn = true;
        Instance = this;
        StartCoroutine(SpawnRoutine());
    }

    void Spawn()
    {
        Vector3 randomPosition = spawnPositions[UnityEngine.Random.Range(0, spawnPositions.Count)].position;
        GameObject obs = Instantiate(obstaclePrefab, randomPosition, Quaternion.identity);
    }
    private IEnumerator SpawnRoutine()
    {
        while (canSpawn)
        {
            Spawn(); 
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
    public void StopSpawn()
    {
        canSpawn = false;

    }
}
