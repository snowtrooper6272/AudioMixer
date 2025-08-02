using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEngineer : MonoBehaviour
{
    [SerializeField] private Switcher _switcher;

    public AudioSource CurrentAudio { get; private set; }

    public void StartClip(AudioSource audio)
    {
        CurrentAudio?.Stop();
        CurrentAudio = audio;
        CurrentAudio.Play();
    }

    public void Turn() 
    {
        _switcher.Turn(CurrentAudio);
    }
}
