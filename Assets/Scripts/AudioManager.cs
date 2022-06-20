using System;
using UnityEngine.Audio;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.Volume;
            s.source.pitch = s.Pitch;
        }
    }

    private void Start()
    {
        Play("Opening");
    }

    public void Play(string name)
    {
        var clip = Array.Find(sounds, sound => sound.name == name);
        clip.source.Play();
    }
}
