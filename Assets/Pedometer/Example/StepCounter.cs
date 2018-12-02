/* 
*   Pedometer
*   Copyright (c) 2018 Yusuf Olokoba
*/

namespace PedometerU.Tests
{

    using UnityEngine;
    using UnityEngine.UI;
    

    public class StepCounter : MonoBehaviour
    {

        public Text stepText, distanceText;
        private Pedometer pedometer;
        public int numberOfEncounters;
        private double assistant = 0;
        public int stepToEncounter;
        public bool inEncounter = false;
        public GameObject walk;
        bool fight = false;

        public GameObject encGo;
        public GameObject lckGo;

        private void Start()
        {
            // Create a new pedometer
            pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
        }

        private void OnStep(int steps, double distance)
        {
            // Display the values // Distance in feet
            stepText.text = steps.ToString();
            //distanceText.text = (distance * 3.28084).ToString("F2") + " ft";
            double distanceVal = steps;
            if (!inEncounter)
            {
                if (distanceVal >= assistant + stepToEncounter)
                {
                    inEncounter = true;
                    assistant = distanceVal;
                    numberOfEncounters++;
                    int tmp = Random.Range(0, 10);
                    if (!fight)
                    {
                        fight = true;
                        encGo.GetComponent<FightReset>().Reset();
                        encGo.SetActive(true);
                        walk.gameObject.SetActive(false);
                    }
                    else
                    {
                        //lckGo.GetComponent<LockMinigameScript>().ArrayInit();
                        lckGo.SetActive(true);
                        walk.gameObject.SetActive(false);
                    }
                    //if (tmp < 6)
                    //{
                        
                    //}
                    //else
                    //{
                        

                    //}
                }
            }
            else
            {
                assistant = distanceVal;
            }
        }

        public void EncounterEnd()
        {
            inEncounter = false;
        }

        private void OnDisable()
        {
            // Release the pedometer
            pedometer.Dispose();
            pedometer = null;
        }
    }
}