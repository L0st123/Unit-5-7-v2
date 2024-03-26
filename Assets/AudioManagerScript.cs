using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    AudioSource audioSource;
    public AudioSource[] audioSources;
    public static AudioManagerScript instance;
    public float sfxvol = 0;
    public float musicvol = 0;

    private void Start()
    {
        
        audioSource.Play();
    }

    

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }
}
