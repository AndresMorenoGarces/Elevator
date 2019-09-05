using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public static Elevator instance;

    Transform elevatorTransform;
    public Transform[] elevatorWayPoints;

    public Transform elevatorDoor;
    Vector3 closeDoor;
    Vector3 openDoor;
    Vector3 dualElevatorDoorPos;

    public float elevatorVelocity = 1f;

    public void ElevatorMove(int _destinyFloor, bool _buttonPress)
    {
        List<int> _floorList = GameManager.instance.floorList;
        elevatorTransform.position = Vector3.MoveTowards(elevatorTransform.position, elevatorWayPoints[_floorList[_destinyFloor]].position, elevatorVelocity * Time.deltaTime);

        if (elevatorTransform.position == elevatorWayPoints[_floorList[_destinyFloor]].position)
        {
            _buttonPress = false;
            DoorState(false);
        }
        else
            DoorState(true);

    }

    public void DoorState(bool elevatorDoorClose)
    {
        dualElevatorDoorPos = elevatorDoorClose ? closeDoor : openDoor;
        elevatorDoor.position = Vector3.MoveTowards(elevatorDoor.position, dualElevatorDoorPos, 2 * Time.deltaTime);
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
        closeDoor = new Vector3(-4f, 2.5f, 1.25f);
        openDoor = new Vector3(-4f, 2.5f, -1f);
    }
}