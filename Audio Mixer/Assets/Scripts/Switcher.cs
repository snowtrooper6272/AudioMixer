using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    public void Turn(AudioSource audio) 
    {
        if (audio == null)
            return;

        if (audio.isPlaying)
            audio.Pause();
        else
            audio.Play();
    }
}
