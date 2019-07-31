using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    void OnMouseEnter()
    {
        Debug.Log("Open");
        //Elevator.elevatorInstance.OpenDoor();
        Elevator.elevatorInstance.ElevatorMove();
        
    }
}
