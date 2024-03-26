using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    AudioSource audioSource;

    private void Start()
    {
        
        audioSource.Play();
    }

    public AudioSource[] audioSources;
     void Awake()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();

    }
    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }
}
