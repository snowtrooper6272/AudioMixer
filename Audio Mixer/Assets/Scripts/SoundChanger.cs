using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundChanger : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    private int _minVolumeValue = -80;
    private int _maxVolumeValue;

    public void ChangeMasterVolume(float volume) 
    {
        _mixer.SetFloat("MasterVolume", Mathf.Lerp(_minVolumeValue, _maxVolumeValue, volume));
    }

    public void ChangeBackgroundVolume(float volume)
    {
        _mixer.SetFloat("BackgroundVolume", Mathf.Lerp(_minVolumeValue, _maxVolumeValue, volume));
    }

    public void ChangeButtonVolume(float volume)
    {
        _mixer.SetFloat("ButtonVolume", Mathf.Lerp(_minVolumeValue, _maxVolumeValue, volume));
    }
}
