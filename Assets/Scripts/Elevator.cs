using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator 
{
    Transform elevatorTransform;
    Transform[] _elevatorWayPoints;
    Transform _doorOne;

    Vector3 distanceElevator_NextFloor;

    public bool ElevatorMove(int _destinyFloor)
    {
        elevatorTransform = GameManager.instance.elevator;
        _elevatorWayPoints = GameManager.instance.elevatorWayPoints;

        distanceElevator_NextFloor = _elevatorWayPoints[_destinyFloor].position - elevatorTransform.position;

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
        _doorOne = GameManager.instance.doorOne;

        if (_doorOne.position.z < -1)
        {
            _doorOne.position += _doorOne.transform.forward * Time.deltaTime;
        }
    }

    public void OpenDoor()
    {
        _doorOne = GameManager.instance.doorOne;

        if (_doorOne.position.z >= -1)
        {
            _doorOne.position -= _doorOne.transform.forward * 0.5f * Time.deltaTime;
        }
    }
}

