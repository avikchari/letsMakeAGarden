using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource comboSFX;
    public AudioSource plantGrowSFX;

    public AudioClip[] comboSounds;
    public AudioClip[] plantGrowSounds;

    public void PlayCombo1()
    {
        comboSFX.clip = comboSounds[0];
        comboSFX.PlayOneShot(comboSFX.clip);
        comboSFX.Play();
    }

    public void PlayCombo2()
    {
        comboSFX.clip = comboSounds[1];
        comboSFX.PlayOneShot(comboSFX.clip);
        comboSFX.Play();
    }
}
