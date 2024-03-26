using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFXSetting : MonoBehaviour
    
{
    [SerializeField] Slider sfxSlider;
    [SerializeField] AudioMixer masterMixer;

    // Start is called before the first frame update
    private void Start()
    {
        float vol = PlayerPrefs.GetFloat("SavedSFXVolume");
        SetVolume(vol);
    }
    public void SetVolume(float _value)
    {
        if(_value < 1)
        {
            _value = .001f;
        }
        RefreshSlider(_value);
        PlayerPrefs.SetFloat("SavedSFXVolume", _value);
        masterMixer.SetFloat("SFXVolume", Mathf.Log10(_value / 100) * 20f);
    }
    public void SetVolumeFromSlider()
    {
        SetVolume(sfxSlider.value);
    }
    public void RefreshSlider(float _value)
    {
        sfxSlider.value = _value;
    }
   
}
