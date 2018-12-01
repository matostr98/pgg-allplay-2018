using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharCreationScript : MonoBehaviour
{

    public Text question;
    public Button yesButton;
    public Button noButton;

    public string seeText = "Papierowe Królestwo potrzebuje bohatera." +
                            "Czy będzie nim wyszkolony w starożytnym klasztorze mnich, " +
                            "który stracił wzrok podczas najazdu na Grafitową Wioskę?";

    public string hearText = "A może bohaterem Papierowego Królestwa jest Prawdawny Samuraj , " +
                             "który wsłuchując się jedynie w swoją duszę opracował technikę walki opartą na wzroku - Gumki-Mazaki?";

    public string moveText = "Nasz Bohater miał niegdyś nieprawdopodobny wypadek - " +
                             "podczas walki z Tekturową Bestią wpadł do Niszczarkanionu. " +
                             "Czy udało mu się wyjść z tego w pełni sprawnym, czy używa jedynie siły woli do projekcji swoich mocy?";

    private int answer = 0;
    public bool firstAnswer;
    public bool secondAnswer;
    public bool thirdAnswer;

    public int[] ans = new int[3] { -1, -1, -1 };

    public bool falseBool;
    public bool trueBool;

    // Use this for initialization
    void Start ()
    {
        question.text = seeText;
    }
	
	// Update is called once per frame 
	//void Update () {
        
	    
 //   }

    public void ChangeToYes()
    {
        ans[answer] = 1;
    }

    public void ChangeToNo()
    {
        ans[answer] = 0;
        answer++;
        Debug.Log("Answer:" + answer.ToString());

        switch (answer)
        {
            case 1:
            {
                Debug.Log("Case 1");
                question.text = hearText;
                break;
            }
            case 2:
            {
                Debug.Log("Case 2");
                question.text = moveText;
                break;
            }
    }
    }

    //public void ChangeAnswer()
    //{
      
    //}
}
