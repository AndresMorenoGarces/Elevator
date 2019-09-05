using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobyButton : MonoBehaviour
{
    public int floor = 0;
    bool buttonPress = false;
    bool onMouseOverButton = false;

    void OnMouseOver()
    {
        onMouseOverButton = true; 
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && onMouseOverButton)
        {
            buttonPress = true;
        }

        if (buttonPress == true)
        {
            GameManager.instance.AddfloorToList(floor);
            Elevator.instance.ElevatorMove(floor, buttonPress);
        }     
        onMouseOverButton = false;
    }
}
