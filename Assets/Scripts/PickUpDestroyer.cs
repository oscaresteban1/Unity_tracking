using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpDestroyer : MonoBehaviour
{
    public string tagTouched;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagTouched))
        {
            ScoreManager.Instance.AddPoints();
            Destroy(gameObject);
        }
    }
}
