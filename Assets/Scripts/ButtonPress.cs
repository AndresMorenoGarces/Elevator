using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public int floor;
    float eTimeToGo = 3f;
    bool buttonPress = false;
    bool onMouseOverButton = false;

    void OnMouseOver()
    {
        onMouseOverButton = true;

        if (buttonPress == true)
        {
            GameManager.instance.AddfloorToList(floor);

            if (Input.GetKey(KeyCode.Mouse0))
            {
                eTimeToGo = 3f;
            }
        }
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && onMouseOverButton)
        {
            buttonPress = true;
        }

        if (eTimeToGo <= 0)
        {
            Elevator.instance.DoorState(true);
            Elevator.instance.ElevatorMove(GameManager.instance.floorList[floor], buttonPress);

        }
        //else if (eTimeToGo > 0 && buttonPress == false)
        //{
        //    eTimeToGo -= Time.deltaTime;
        //}

        onMouseOverButton = false;
    }
}
