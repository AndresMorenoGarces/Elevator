using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public int floor = 0;

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Elevator.instance.isDoorOpen == false)
        {
            Elevator.instance.FloorDoorIndex(floor);
            Elevator.instance.SetOnlyOneFloorToGo();
        }
    }
}
//List<int> _elevatorFloorList = GameManager.instance.elevatorFloorList;
//GameManager.instance.AddElevatorfloorToList(floor);
//if (Elevator.instance.eDoorState == true)
//{
//}