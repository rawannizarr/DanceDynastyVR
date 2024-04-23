using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicOnClick : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GameObject.FindWithTag("Music").GetComponent<AudioSource>();
    }
    public void PlayMusic()
    {
        audioSource.Play();
    }
}