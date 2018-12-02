using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narration : MonoBehaviour
{

    public List<AudioClip> audioClips;
    public List<float> delays;
    public AudioSource audioSource;
    public bool playNarration = true;
    public float delayBetweenClips = 0.75f;
    public bool repeat = false;

	// Use this for initialization
	void Start ()
	{
	    audioSource = FindObjectOfType<AudioSource>();
        if(playNarration)
	        StartCoroutine(PlayNarration());
	}

    public IEnumerator PlayNarration()
    {
        if(!repeat)
            playNarration = false;

        foreach (var clip in audioClips)
        {
            audioSource.PlayOneShot(clip);
            yield return new WaitForSeconds(clip.length + delayBetweenClips);
        }
    }
}
