using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private SpawnObstacle spawnobstacle;
    public float gravityMult;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(Physics.gravity * gravityMult, ForceMode.Acceleration);
    }
    public void SetSpawner(SpawnObstacle spawner)
    {
        spawnobstacle = spawner;
    }
}
