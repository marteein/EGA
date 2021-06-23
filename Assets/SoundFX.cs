using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    static SoundFX instance = null;

    //Each soundeffect can be defined in the inspector
    public AudioClip start;

    //Functions exactly the same as the MusicManager
    void Awake () {
        AudioSource audio = GetComponent<AudioSource> ();
        if (instance != null) {
        Destroy(gameObject);
        print ("SFX destroyed!");
        }
        else {
        instance = this;
        GameObject.DontDestroyOnLoad(gameObject);
        }
        audio.clip = start; 
        audio.Play ();
    }

}
