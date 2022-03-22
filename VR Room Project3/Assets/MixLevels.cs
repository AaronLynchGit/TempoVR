using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixLevels : MonoBehaviour
{
    public AudioMixer masterMixer;
    //public float cutOffLvl = 0.0f; Synth1Delay Synth1Reverb Synth1Volume Synth1DelayFreq DrumLowPass

    public void SetCutOffLvl(float cutOffLvl)
    {
        masterMixer.SetFloat("Synth1Cutoff", cutOffLvl);
    }

    public void SetDelayLvl(float delayLvl)
    {
        masterMixer.SetFloat("Synth1Delay", delayLvl);
    }

    public void SetDelayFreqLvl(float delayFreqLvl)
    {
        masterMixer.SetFloat("Synth1DelayFreq", delayFreqLvl);
    }

    public void SetDistortDriveLvl(float distortDriveLvl)
    {
        masterMixer.SetFloat("Synth1DistortionDrive", distortDriveLvl);
    }

    public void SetReverbLvl(float reverbLvl)
    {
        masterMixer.SetFloat("Synth1Reverb", reverbLvl);
    }

    public void SetVolumeLvl(float volumeLvl)
    {
        masterMixer.SetFloat("Synth1Volume", volumeLvl);
    }

    public void SetDelayDrum(float drumDelayLvl)
    {
        masterMixer.SetFloat("DrumDelay", drumDelayLvl);
    }

    public void SetDrumLowPass(float drumLowPassLvl)
    {
        masterMixer.SetFloat("DrumLowPass", drumLowPassLvl);
    }

}
