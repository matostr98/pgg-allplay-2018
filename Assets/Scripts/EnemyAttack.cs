using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    public int enemyAttackSpeed;

    public bool inEncounter;

    public bool attacking;
	// Use this for initialization
	void Start () {
		
	}

    public IEnumerator enemyAttack()
    {
        yield return new WaitForSeconds(enemyAttackSpeed);
        Handheld.Vibrate();
        //player hurt
        attacking = true;
        Debug.Log("VIBRATE!");

    }

    public void combat()
    {
        if (inEncounter)
        {
            StartCoroutine(enemyAttack());
        }
    }

    public void setInEncounter()
    {
        inEncounter = true;
    }

	// Update is called once per frame
	void Update () {
	    
	}
}
