using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum audioClips_soundtrack//referencias de sonidos de las canciones
{
    none,
    song_1,
    song_2,
}

public enum audioclips_sfx//referenias de efectos de sonidos como objetos
{
    none,
    walk,
    auto,
    punch,
    bullet,
}
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioSource audioSource;// brackground music / soundtrack / songs
    public AudioSource audioSourceEffectref;//vfx / ui
    public AudioClip[] audioClipsSoundtrack;
    public AudioClip[] audioClipsSfx;
    public float soundtrackVolume = (3f);
    public float sfvolumen = 3f;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }
    public void setAudioclipSoundtrack(audioClips_soundtrack audioClips_Soundtrack)
    {
        audioSource.Stop();//detener el audio anterior existente
        audioSource.PlayDelayed(0.3f);//tiempo de detenido para reproducir siguiente
        //reproduccion de la cancion con un volumen dado
        audioSource.PlayOneShot(audioClipsSoundtrack[(int)audioClips_Soundtrack], soundtrackVolume);
    }

    public void setaudiovfx(AudioSource audioSource, audioclips_sfx sudioclips_Sfx)
    {
        audioSource.PlayOneShot(audioClipsSfx[(int)sudioclips_Sfx], sfvolumen);
        audioSourceEffectref = audioSource;
    }
    //public float modifycurrevolumen()
   // {
     //   audioSource.volume = volumenref;
    //    audioSourceEffectref.volume;
   // }
}
