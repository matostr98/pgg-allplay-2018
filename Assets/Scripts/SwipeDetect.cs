using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeDetect : MonoBehaviour
{
    public Text directionText;
    public Text swipingText;

    public enum SwipeDirection
    {
        Up,
        Down,
        Right,
        Left
    }

    public static event Action<SwipeDirection> Swipe;
    private bool swiping = false;
    private bool eventSent = false;
    private Vector2 lastPosition;

    void Update()
    {
        if (Input.touchCount == 0)
            return;

        if (Input.GetTouch(0).deltaPosition.sqrMagnitude != 0)
        {
            if (swiping == false)
            {
                swiping = true;
                //swipingText.text = swiping.ToString();
                lastPosition = Input.GetTouch(0).position;
                return;
            }
            else
            {
                if (!eventSent)
                {

                    if (Swipe == null)
                    {
                        Vector2 direction = Input.GetTouch(0).position - lastPosition;

                        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
                        {
                            if (direction.x > 0)
                            {
                                Debug.Log("right");
                                //directionText.text = "right";
                                //Swipe(SwipeDirection.Right);
                            }
                            else
                            {
                                Debug.Log("left");
                                //directionText.text = "left";
                                //Swipe(SwipeDirection.Left);
                            }
                                
                        }
                        else
                        {
                            if (direction.y > 0)
                            {
                                Debug.Log("up");
                                //directionText.text = "up";
                                //Swipe(SwipeDirection.Up);
                            }
                            else
                            {
                                Debug.Log("down");
                                //directionText.text = "down";
                                //Swipe(SwipeDirection.Down);
                            }
                                
                        }

                        eventSent = true;
                    }
                }
            }
        }
        else
        {
            swiping = false;
            //swipingText.text = swiping.ToString();
            eventSent = false;
        }
    }
}
