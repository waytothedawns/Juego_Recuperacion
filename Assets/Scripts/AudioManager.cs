using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider sliderVolume;
    [SerializeField] AudioMixer audioMixer;
    public void SetVolume()
    {
        audioMixer.SetFloat("mainVolume", sliderVolume.value);
        
    }
}
