using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] audioClips;
    public static AudioManager instance;

    private AudioSource player;

    private void Awake()
    {
        player = GetComponent<AudioSource>();
    }

    void Start()
    {
        if (instance == null) instance = this;
    }

    public void playSound(AudioClip clip)
    {
        player.clip = clip;
        player.Play();
    }
    public static AudioClip[] GetClips()
    {
        return instance.audioClips;
    }
    
    public static void PlaySound(AudioClip clip)
    {
        instance.playSound(clip);
    }
}
