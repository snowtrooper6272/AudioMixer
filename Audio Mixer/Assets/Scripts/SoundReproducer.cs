using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundReproducer : MonoBehaviour
{
    [SerializeField] private Button _reproduceButton;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private SoundEngineer _soundEngineer;

    private void OnEnable()
    {
        _reproduceButton.onClick.AddListener(Play);
    }

    private void OnDisable()
    {
        _reproduceButton.onClick.RemoveListener(Play);
    }

    private void Play() 
    {
        _soundEngineer.SwitchClip(_audio);
    }
}
