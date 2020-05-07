using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickUp : MonoBehaviour
{

    public GameObject pickupPrefab;
    public List<Transform> spawnPositions = new List<Transform>();

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i<4; i++)
        {
            // spawn with some deviation
            Vector3 Position = spawnPositions[i].position + new Vector3(UnityEngine.Random.Range(-50, 50), UnityEngine.Random.Range(-50, 50), 0);
            GameObject obs = Instantiate(pickupPrefab, Position, Quaternion.identity);
        }
    }

}
