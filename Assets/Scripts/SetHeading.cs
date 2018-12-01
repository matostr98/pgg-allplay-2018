using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetHeading : MonoBehaviour {


    public Text desiredHeading;
    public Text currentHeading;
    public Camera camera;

	// Use this for initialization
	void Start () {
        Input.location.Start();
        camera = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void SetRandomHeading()
    {
        int heading;

        heading = Random.Range(0, 3);

        switch (heading)
        {
            case 0:
                desiredHeading.text = "N";
                break;
            case 1:
                desiredHeading.text = "S";
                break;
            case 2:
                desiredHeading.text = "W";
                break;
            case 3:
                desiredHeading.text = "E";
                break;
            default:
                desiredHeading.text = "Error";
                break;
        }
    }
}
