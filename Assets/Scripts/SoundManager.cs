using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip wilhelm;
    public AudioClip windows;

    private Vector3 cameraPosition; 

    void Awake()
    {
        Instance = this;
        cameraPosition = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void PlaySound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition);
    }
    public void PlayWilhelm()
    {
        PlaySound(wilhelm);
    }
    public void PlayWindows()
    {
        PlaySound(windows);
    }
}
