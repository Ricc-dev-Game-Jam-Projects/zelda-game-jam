using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    private string SelectedMusicBg = "";
    private Sound SelMusic;

    public bool AutoPlay;
    public string[] AutoMusics;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
            return;
        }

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Update()
    {
        if(AutoMusics.Length > 0 && AutoPlay)
        {
            if(SelMusic == null || !SelMusic.source.isPlaying)
            {
                int musicPos = UnityEngine.Random.Range(0, AutoMusics.Length - 1);

                if (SelectedMusicBg != "") Stop(SelectedMusicBg);

                SelectedMusicBg = AutoMusics[musicPos];
                SelMusic = Play(SelectedMusicBg);
                if (SelMusic == null)
                {
                    Debug.LogError("MUSIC NULL!?");
                }
                SelMusic.source.loop = false;
            }
        }
    }

    public Sound Play(string music)
    {
        Sound s = Array.Find(sounds, sound => sound.name == music);
        if(s == null)
        {
            Debug.LogWarning("Music not found: " + music);
            return null;
        }
        s.source.Play();
        return s;
    }

    public void Stop(string music)
    {
        Sound s = Array.Find(sounds, sound => sound.name == music);
        if(s == null)
        {
            Debug.LogWarning("Music not found: " + music);
            return;
        }
        s.source.Stop();
    }

    public void Stop()
    {
        Stop(SelectedMusicBg);
    }
}
