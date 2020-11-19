using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip[] clips;
    AudioSource source;

    public void PlayTutorial(int index)
    {
        source.clip = clips[index];
        source.Play();
    }


    void Start()
    {
        source = GetComponent<AudioSource>();
    }
}
