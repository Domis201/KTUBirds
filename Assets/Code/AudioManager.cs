using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio clip --------")]
    public AudioClip background;
    public AudioClip hitTheBox;
    public AudioClip hitTheMonster;
    public AudioClip shootTheChicken;
    public AudioClip buttonClick;

    private void Start()
    {
        musicSource.clip = background;
        if (this != null) musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
