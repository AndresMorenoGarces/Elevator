using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobyButton : MonoBehaviour
{
    public int floor = 0;

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Elevator.instance.FloorDoorIndex(floor);
            Elevator.instance.SetOnlyOneFloorToGo();
        }     
    }
}
