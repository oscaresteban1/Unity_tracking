using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleDestroyer : MonoBehaviour
{
    public string tagFilter;
    public string tagTouched;

    private void LateUpdate()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tagFilter))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag(tagTouched))
        {
            ScoreManager.Instance.Ended(this.gameObject);
            gameObject.SetActive(false);
        }
    }



}