using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private int score = 0;
    private int neededPoints = 4;


    void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddPoints()
    {
        score++;
        
        if (score == neededPoints)
        {
            SoundManager.Instance.PlayWindows();
            SpawnObstacle.Instance.canSpawn = false;
        }
    }
    public void Ended(GameObject obj)
    {
        StartCoroutine(End(obj));
    }
    private IEnumerator End(GameObject obj)
    {
        SoundManager.Instance.PlayWilhelm();
        yield return new WaitForSeconds(2);
        obj.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
