using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private SpawnPickUp spawnpickup;

    void Update()
    {
        transform.Rotate(50*Time.deltaTime, 0, 50*Time.deltaTime);
    }


}
