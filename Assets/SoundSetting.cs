using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour
    
{
    [SerializeField] Slider soundSlider;
    [SerializeField] AudioMixer masterMixer;

    // Start is called before the first frame update
    private void Start()
    {
        float vol = PlayerPrefs.GetFloat("SavedMusicVolume");
        SetVolume(vol);
    }
    public void SetVolume(float _value)
    {
        if(_value < 1)
        {
            _value = .001f;
        }
        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedMusicVolume", _value);
        masterMixer.SetFloat("MusicVolume", Mathf.Log10(_value / 100) * 20f);
    }
    public void SetVolumeFromSlider()
    {
        SetVolume(soundSlider.value);
    }
    public void RefreshSlider(float _value)
    {
        soundSlider.value = _value;
    }
   
}
