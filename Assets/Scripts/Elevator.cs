using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public static Elevator elevatorInstance;
    // Transform elevatorTransform;
    public Transform[] elevatorWayPoints;
    // int currentFloor = 0;
    public float elevatorSpeed;
    Vector3 distanceElevator_NextFloor;
    public Transform doorOne;


    public void ElevatorMove()
    {
        Debug.Log("lool");
        // distanceElevator_NextFloor = elevatorWayPoints[1].position - transform.position;

        // if (distanceElevator_NextFloor.magnitude > 1)
        // {
        //     transform.position += transform.up;
        // }
        // else
        // {
        //     Debug.Log("It´s here!");
        // }
    }

    public void CloseDoor()
    {
        if (doorOne.position.z <= 0)
        {
            doorOne.position += doorOne.transform.right;           
        }
    }
    public void OpenDoor()
    {
        if (doorOne.position.z >= -1)
        {
            doorOne.position -= doorOne.transform.right;           
        }
    }

    void Start()
    {
    }
}
