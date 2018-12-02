using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightReset : MonoBehaviour
{

    public Button continueButton;
    public Image arrow;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Reset()
    {
        continueButton.gameObject.SetActive(false);
        arrow.gameObject.SetActive(true);
    }
}
