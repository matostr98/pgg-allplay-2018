using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummaryScript : MonoBehaviour
{

    public AudioClip audio;
    public AudioSource audioSrc;
    public GameObject script;

    public Text question;

    public string monkTxt = "Nasz Bohater to  wyszkolony w starożytnym klasztorze mnich, który stracił wzrok podczas" +
                            " najazdu na Grafitową Wioskę. Nie używa wzroku do rozgrywki, co nie przeszkadza mu" +
                            " w wyostrzeniu pozostałych zmysłów do walki z Lordem Gryzmołem.";

    public string samuraiTxt ="Nasz Bohater to Prawdawny Samuraj, który wsłuchując się jedynie w swoją duszę opracował" +
                              "technikę walki opartą na wzroku - Gumki-Mazaki. Nie używa słuchu do rozgrywki, co nie przeszkadza mu" +
                             " w wyostrzeniu pozostałych zmysłów do walki z Lordem Gryzmołem";

    public string accidentTxt = "Niestety - Niszczarkanion uszkodził trwale naszego Bohatera. " +
                                "Będzie musiał pokonać arcywroga siłą woli, wykorzystując mistyczną telekinezę unieruchomiony " +
                                "podczas powrotu do zdrowia w Klasztorze Cyrkielików.";

    public string noaccidentTxt =
        "Mimo sytuacji z Niszczarkanionem, nasz Bohater wyrusza w podróż gotów machać mieczem i składać czary.";

    // Use this for initialization
    void Start ()
	{
	    audioSrc = FindObjectOfType<AudioSource>();

	    if (script.GetComponent<CharCreationScript>().ans[0] == 1)
	    {
	        question.text = monkTxt;
	    } else if (script.GetComponent<CharCreationScript>().ans[1] == 1)
	    {
	        question.text = samuraiTxt;
        }
	    else if (script.GetComponent<CharCreationScript>().ans[2] == 1)
	    {
	        question.text = accidentTxt;
	    }
	    else
	    {
	        question.text = noaccidentTxt;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
