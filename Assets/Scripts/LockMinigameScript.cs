using System.Collections;
using System.Collections.Generic;
using PedometerU.Tests;
using UnityEngine;
using UnityEngine.UI;

public class LockMinigameScript : MonoBehaviour {

    //lock
        int arrLength = 0; 
        int [] lockArray;
	    int progress = 0;

    //Buttons and colors
        public Button buttonLeft;
        public Button buttonRight;
        Color incorrectColor = Color.red;
	    Color correctColor = Color.blue;
        Color endColor = Color.magenta;

        ColorBlock cbLeft;
        ColorBlock cbRight;
        public GameObject player;
        public GameObject walk;

        public AudioClip lockUnlock;
        public AudioClip lockBreak;
        public AudioClip lockClick;
        public AudioSource audioSource;

    void Start ()
	{
        
        cbLeft = buttonLeft.colors;
	    cbRight = buttonRight.colors;
	    audioSource = FindObjectOfType<AudioSource>();


        //cb.pressedColor = wrongColor;
        //buttonLeft.colors = cb;

	    arrLength = Random.Range(4, 8);
	    lockArray = new int[arrLength];

	    for (int i = 0; i < arrLength; i++)
	    {
	        int temp = Random.Range(1, 3);
	        lockArray[i] = temp;
	    }

	    //Chamska inicjalizacja
	    if (lockArray[0] == 1)
	    {
	        cbLeft.pressedColor = correctColor;
	        buttonLeft.colors = cbLeft;
	        cbRight.pressedColor = incorrectColor;
	        buttonRight.colors = cbRight;
	    }
	    else
	    {
	        cbLeft.pressedColor = incorrectColor;
	        buttonLeft.colors = cbLeft;
	        cbRight.pressedColor = correctColor;
	        buttonRight.colors = cbRight;
	    }
    }

    public void ArrayInit()
    {
        arrLength = Random.Range(4, 8);
        lockArray = new int[arrLength];

        for (int i = 0; i < arrLength; i++)
        {
            int temp = Random.Range(1, 3);
            lockArray[i] = temp;
        }

        //Chamska inicjalizacja
        if (lockArray[0] == 1)
        {
            cbLeft.pressedColor = correctColor;
            buttonLeft.colors = cbLeft;
            cbRight.pressedColor = incorrectColor;
            buttonRight.colors = cbRight;
        }
        else
        {
            cbLeft.pressedColor = incorrectColor;
            buttonLeft.colors = cbLeft;
            cbRight.pressedColor = correctColor;
            buttonRight.colors = cbRight;
        }
    }

    public void VerifyLock(int ver)
    {
        
        if (progress < arrLength - 1)
        {
            if (lockArray[progress + 1] == 1)
            {
                cbLeft.pressedColor = correctColor;
                buttonLeft.colors = cbLeft;
                cbRight.pressedColor = incorrectColor;
                buttonRight.colors = cbRight;
            }
            else
            {
                cbLeft.pressedColor = incorrectColor;
                buttonLeft.colors = cbLeft;
                cbRight.pressedColor = correctColor;
                buttonRight.colors = cbRight;
            }
        }

        if (ver == lockArray[progress])
        {

            // click sound
            if (progress != arrLength - 1)
            {
                audioSource.PlayOneShot(lockClick);
                progress++;
            }
            else
            {
                audioSource.PlayOneShot(lockUnlock);
                walk.SetActive(true);
                player.GetComponent<StepCounter>().EncounterEnd();
                player.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
        else
        {
            //crack sound
            audioSource.PlayOneShot(lockBreak);
            progress = 0;
            if (lockArray[0] == 1)
            {
                cbLeft.pressedColor = correctColor;
                buttonLeft.colors = cbLeft;
                cbRight.pressedColor = incorrectColor;
                buttonRight.colors = cbRight;
            }
            else
            {
                cbLeft.pressedColor = incorrectColor;
                buttonLeft.colors = cbLeft;
                cbRight.pressedColor = correctColor;
                buttonRight.colors = cbRight;
            }
        }
    }
}
