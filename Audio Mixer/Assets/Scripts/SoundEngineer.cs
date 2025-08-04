using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEngineer : MonoBehaviour
{
    [SerializeField] private Switcher _switcher;

    public AudioSource CurrentAudio { get; private set; }

    public void SwitchClip(AudioSource audio)
    {
        CurrentAudio?.Stop();
        CurrentAudio = audio;
        CurrentAudio.Play();
    }

    public void Switch(bool isOn) 
    {
        if (isOn)
            _switcher.SwitchOn();
        else
            _switcher.SwitchOff();
    }
}
