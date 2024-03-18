using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenu : MonoBehaviour
{
    [SerializeField] public AudioSource audioSource;
    [SerializeField] public AudioClip audioClip;

    public void ClickSound()
    {
        audioSource.PlayOneShot(audioClip);
    }

    public void FlySound()
    {
        audioSource.PlayOneShot(audioClip);
    }
}
