using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyScript : MonoBehaviour {

    public string txt = "Przed wyruszeniem w drogę Nasz Bohater odwiedził wyrocznię - DruchKarkę. "+
    "Ta przekazała mu krótką przepowiednię, która w przyszłości ma zawładnąć jego losem. Ta przepowiednia to:";
    public Text question;
    
	// Use this for initialization
	void Start () {
		question.text = txt;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
