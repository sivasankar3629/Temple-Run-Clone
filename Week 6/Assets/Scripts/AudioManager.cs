using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider slider;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Volume"))
        {
            LoadVolume();
        }
        else
        {
            SetVolume();
        }
        
    }
    public void SetVolume()
    {
        float volume = slider.value;
        audioMixer.SetFloat("music",Mathf.Log(volume) * 15);
        PlayerPrefs.SetFloat("Volume", volume);
    }

    void LoadVolume()
    {
        slider.value = PlayerPrefs.GetFloat("Volume");
        SetVolume();
    }
}
