using System.Collections;
using System.Collections.Generic;
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
        public GameObject walk;
	
	void Start ()
	{
        
        cbLeft = buttonLeft.colors;
	    cbRight = buttonRight.colors;

        

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
	    




	    Debug.Log("Array Length" + arrLength.ToString());
	    string temp2 = "";
        for (int i = 0; i < arrLength; i++)
        {
            temp2 += lockArray[i].ToString() + "  p:" + progress;

        }
	    Debug.Log("Num: " + temp2);
	    string temp3 = "";
	    for (int i = 0; i < progress; i++)
	    {
	        temp3 += "  ";
	    }
	    Debug.Log(temp3 + "^ " + lockArray[progress] + " " + progress);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void VerifyLock(int ver)
    {
        string temp2 = "";
        for (int i = 0; i < arrLength; i++)
        {
            temp2 += lockArray[i].ToString() + " ";

        }
        Debug.Log("" + temp2 + "  v: " + ver + "  p:" + progress);
        string temp3 = "";
        for (int i = 0; i <= progress; i++)
        {
            temp3 += "  ";
        }
        Debug.Log(temp3 + "^ " + lockArray[progress] + " " + progress);

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
            Debug.Log(lockArray[progress] + " " + progress);

            // click sound
            if (progress != arrLength - 1)
            {
                progress++;
            }
            else
            {
                walk.SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
        else
        {
            //crack sound
            Debug.Log("u fkd up");
            progress = 0;
            incorrectLockpicking(ver);
            
            temp3 = "";
            for (int i = 0; i < progress; i++)
            {
                temp3 += "  ";
            }
            Debug.Log(temp3 + "^ " + lockArray[progress] + " " + progress);
        }
    }

    private void correctLockpicking(int v)
    {
        if (v == 1)
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

    private void incorrectLockpicking(int v)
    {
        if (v == 1)
        {
            cbLeft.pressedColor = incorrectColor;
            buttonLeft.colors = cbLeft;
            cbRight.pressedColor = correctColor;
            buttonRight.colors = cbRight;
           
        }
        else
        {
            cbLeft.pressedColor = correctColor;
            buttonLeft.colors = cbLeft;
            cbRight.pressedColor = incorrectColor;
            buttonRight.colors = cbRight;
        }
    }
}
