using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator 
{
    Transform elevatorTransform;
    public Transform[] elevatorWayPoints;
    public Transform doorOne;

    Vector3 distanceElevator_NextFloor;

    [HideInInspector]
    public int destinyFloor = 0;

    public bool ElevatorMove()
    {
         distanceElevator_NextFloor = elevatorWayPoints[destinyFloor].position - elevatorTransform.position;

        if (distanceElevator_NextFloor.magnitude > 0.1f)
        {
            elevatorTransform.position += distanceElevator_NextFloor * 2f * Time.deltaTime;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void CloseDoor()
    {
        if (doorOne.position.z < -1)
        {
            doorOne.position += doorOne.transform.forward * Time.deltaTime;
        }
    }

    public void OpenDoor()
    {
        if (doorOne.position.z >= -1)
        {
            doorOne.position -= doorOne.transform.forward * 0.5f * Time.deltaTime;
        }
    }

    private void Awake()
    {
        elevatorTransform = GameObject.Find("Elevator").transform;
    }
}

enum ElevatorMove
{
    Move,
    Stop
};
