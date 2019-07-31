using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public static Elevator elevatorInstance;
    Transform elevatorTransform;
    public Transform[] elevatorWayPoints;
    int currentFloor = 0;
    public float elevatorSpeed;
    Vector3 distanceElevator_NextFloor;
    public Transform doorOne;

    public void ElevatorMove()
    {
         distanceElevator_NextFloor = elevatorWayPoints[currentFloor].position - elevatorTransform.position;

         if (distanceElevator_NextFloor.magnitude > 0)
         {
            elevatorTransform.position += distanceElevator_NextFloor * 1f * Time.deltaTime;
         }
    }

    public bool CloseDoor()
    {
        if (doorOne.position.z < -1)
        {
            doorOne.position += doorOne.transform.forward * Time.deltaTime;

            return true;
        }
        return false;
    }

    public bool OpenDoor()
    {
        if (doorOne.position.z >= -1)
        {
            doorOne.position -= doorOne.transform.forward * 0.5f * Time.deltaTime;

            return true;
        }
        return false;
    }

    private void Awake()
    {
        elevatorTransform = transform;
    }

    private void Update()
    {
        ElevatorMove();
    }
}
