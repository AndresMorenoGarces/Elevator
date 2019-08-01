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

        if (distanceElevator_NextFloor.magnitude > 0.1f)
        {
            elevatorTransform.position += distanceElevator_NextFloor * 1f * Time.deltaTime;
            CloseDoor();
        }
        else if (distanceElevator_NextFloor.magnitude <= 0.1f)
        {
            OpenDoor();
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
        elevatorTransform = transform;

        if (elevatorInstance == null)
        {
            elevatorInstance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
enum ElevatorMove
{
    Move,
    Stop
};
