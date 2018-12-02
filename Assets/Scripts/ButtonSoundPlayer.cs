using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundPlayer : MonoBehaviour {

    public AudioClip buttonSound;
    public AudioSource audioSource;


    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        
    }


    public void PlaySound()
    {
        audioSource.PlayOneShot(buttonSound);
    }
}
