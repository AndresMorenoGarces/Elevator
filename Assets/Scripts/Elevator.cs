using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public static Elevator instance;

    Transform elevatorTransform;
    public Transform[] elevatorWayPoints;
    public Transform[] doorTransforms;

    Vector3 closeDoor;
    Vector3 openDoor;
    Vector3 dualElevatorDoorPos;
    Vector3 positionToGo;

    int floorInt;

    public float elevatorVelocity = 1f;

    bool eDoorState = false;


    public void SetOnlyOneFloorToGo(int posFloor)
    {
        positionToGo = elevatorWayPoints[posFloor].position;

       
    }

    void Update()
    {
        closeDoor = new Vector3(-4f, doorTransforms[floorInt].position.y, 1.25f);
        openDoor = new Vector3(-4f, doorTransforms[floorInt].position.y, -1f);
        dualElevatorDoorPos = eDoorState ? closeDoor : openDoor;

        if (elevatorTransform.position == positionToGo)
        {
            Elevator.instance.DoorStateClose(floorInt);
            eDoorState = false;
        }
        else
            eDoorState = true;

        elevatorTransform.position = Vector3.MoveTowards(elevatorTransform.position, positionToGo, elevatorVelocity * Time.deltaTime);
        doorTransforms[floorInt].position = Vector3.MoveTowards(doorTransforms[floorInt].position, dualElevatorDoorPos, 2 * Time.deltaTime);

    }    

    public void DoorStateClose(int posFloor)
    {
        
        floorInt = posFloor;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        elevatorTransform = transform;
    }

    private void Start()
    {
        positionToGo = this.transform.position;

    }
}