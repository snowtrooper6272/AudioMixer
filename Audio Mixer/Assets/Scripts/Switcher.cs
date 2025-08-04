using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Switcher : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;
    [SerializeField] private Slider _masterVolumeSlider;
    [SerializeField] private Button _switchOnButton;
    [SerializeField] private Button _switchOffButton;

    private string _masterVolume = "MasterVolume";
    private float _pastVolumeMixer;
    private float _pastValueSlider;

    private void OnEnable()
    {
        _switchOnButton.onClick.AddListener(SwitchOn);
        _switchOffButton.onClick.AddListener(SwitchOff);
    }

    private void OnDisable()
    {
        _switchOnButton.onClick.RemoveListener(SwitchOn);
        _switchOffButton.onClick.RemoveListener(SwitchOff);
    }

    public void SwitchOff() 
    {
        float muteVolume = -80;
        _mixer.GetFloat(_masterVolume, out float pastVolume);

        _pastVolumeMixer = pastVolume;
        _pastValueSlider = _masterVolumeSlider.value;

        _mixer.SetFloat(_masterVolume, muteVolume);
        _masterVolumeSlider.value = 0;
        _masterVolumeSlider.interactable = false;
    }

    public void SwitchOn() 
    {
        _mixer.SetFloat(_masterVolume, _pastVolumeMixer);
        _masterVolumeSlider.value = _pastValueSlider;
        _masterVolumeSlider.interactable = true;
    }
}
