using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    [SerializeField]
    ElevatorMove elevatorMove;

    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            elevatorMove = ElevatorMove.Move;
        }
        else
        {
            elevatorMove = ElevatorMove.Stop;
        }

        if (elevatorMove == ElevatorMove.Move)
        {
            Elevator.elevatorInstance.ElevatorMove();
        }
    }
}
