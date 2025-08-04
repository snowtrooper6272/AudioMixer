using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.UI;

public class SoundChanger : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _slider;
    [SerializeField] private string _mixerGroupName;

    private int _minVolumeValue = -80;
    private int _maxVolumeValue;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    public void ChangeVolume(float volume) 
    {
        _mixer.SetFloat(_mixerGroupName, Mathf.Lerp(_minVolumeValue, _maxVolumeValue, volume));
    }
}
