using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    void OnMouseEnter()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Elevator.elevatorInstance.ElevatorMove();

            Elevator.elevatorInstance.OpenDoor();
        }
    }
}
