using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class ButtonHighlight : MonoBehaviour, ISelectHandler, IPointerEnterHandler, IPointerExitHandler
{

    public AudioClip buttonSound;
    public AudioClip buttonOut;
    public AudioClip buttonIn;
    public AudioSource audioSource;
    public static string lastHighlighted;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }

    // When highlighted with mouse.
    public void OnPointerEnter(PointerEventData eventData)
    {
        audioSource.PlayOneShot(buttonIn);
        Debug.Log("---" + this.name + " -- " + lastHighlighted);
        // Do something.
        if (lastHighlighted != this.name)
        {
            audioSource.PlayOneShot(buttonSound);
            Debug.Log("<color=red>Event:</color> Completed mouse highlight.");
            lastHighlighted = this.name;
        }

    }


    // When selected.
    public void OnSelect(BaseEventData eventData)
    {
        // Do something.
        Debug.Log("<color=red>Event:</color> Completed selection.");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("<color=red>Event:</color> exit pointer.");
        audioSource.PlayOneShot(buttonOut);
    }
}
