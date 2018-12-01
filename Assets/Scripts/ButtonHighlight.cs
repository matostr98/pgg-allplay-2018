using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ButtonHighlight : MonoBehaviour, ISelectHandler, IPointerEnterHandler
{

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

    // When highlighted with mouse.
    public void OnPointerEnter(PointerEventData eventData)
    {
        // Do something.
        PlaySound();
        Debug.Log("<color=red>Event:</color> Completed mouse highlight.");
        
    }
    // When selected.
    public void OnSelect(BaseEventData eventData)
    {
        // Do something.
        Debug.Log("<color=red>Event:</color> Completed selection.");
//        PlaySound();
    }
}
