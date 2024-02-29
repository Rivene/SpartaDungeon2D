using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundManager : MonoBehaviour
{
    public AudioMixer mixer;
    public void isAudioBtn()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }

    public void AudioControl(float sliderVal)
    {
        mixer.SetFloat("BGM", Mathf.Log10(sliderVal) * 20);
    }
}
