using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class CharCreationScript : MonoBehaviour
{

    public Text question;
    public Text yes;
    public Text no;

    public GameObject go;


    public string seeText = "Papierowe Królestwo potrzebuje bohatera." +
                            "Czy będzie nim wyszkolony w starożytnym klasztorze mnich, " +
                            "który stracił wzrok podczas najazdu na Grafitową Wioskę?";

    public string hearText = "A może bohaterem Papierowego Królestwa jest Prawdawny Samuraj , " +
                             "który wsłuchując się jedynie w swoją duszę opracował technikę walki opartą na wzroku - Gumki-Mazaki?";

    public string moveText = "Nasz Bohater miał niegdyś nieprawdopodobny wypadek - " +
                             "podczas walki z Tekturową Bestią wpadł do Niszczarkanionu. " +
                             "Czy udało mu się wyjść z tego w pełni sprawnym, czy używa jedynie siły woli do projekcji swoich mocy?";

    public string noTxt = "NO";
    public string yesTxt = "YES";
    public string aNoTxt = "Wyszedł bez szwanku (porusza się)";
    public string aYesTxt = "Używa siły woli (nie porusza się)";


    private int answer = 0;
    public int[] ans = new int[3] { -1, -1, -1 };


    // Use this for initialization
    void Start ()
    {
        question.text = seeText;
        yes.text = yesTxt;
        no.text = noTxt;
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

        //Debug.Log("Answer:" + answer.ToString());
        if (answer < 3)
        {
            ans[answer] = 0;
            answer++;
        }
        

        switch (answer)
        {
            case 1:
            {
                //Debug.Log("Case 1");
                question.text = hearText;

                break;
            }
            case 2:
            {
                //Debug.Log("Case 2");
                question.text = moveText;
                yes.text = aYesTxt;
                no.text = aNoTxt;
                break;
            }
    }
        
    }

    public void noChange()
    {
        //Debug.Log("Three nos");
        if (answer > 2)
        {
            go.SetActive(true);
            this.gameObject.SetActive(false);
            
        }
    }


}
