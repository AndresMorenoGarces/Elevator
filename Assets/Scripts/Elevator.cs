using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public static Elevator instance;

    [HideInInspector]
    public Transform elevatorTransform;
    public Transform[] elevatorWayPoints;
    public Transform[] elevatorLeftDoors;
    public Transform[] elevatorRightDoors;

    Vector3 positionToGo;
    Vector3 leftDoorPos;
    Vector3 rightDoorPos;

    int floorNum = 0;
    public float elevatorVelocity = 1f;

    bool isfloorSelected = false;

    [HideInInspector]
    public bool isDoorOpen= false;


    public void FloorDoorIndex(int posFloor)
    {
        floorNum = posFloor;
        isfloorSelected = true;
    }

    public void ElevatorDoorState(bool isOpen)
    {
        if (isOpen == true)
        {
            leftDoorPos = new Vector3(-4.1f, elevatorLeftDoors[floorNum].position.y, -3.25f);
            rightDoorPos = new Vector3(-4.1f, elevatorRightDoors[floorNum].position.y, 3.25f);

            if (elevatorRightDoors[floorNum].position == rightDoorPos)
            {
                isDoorOpen = true;
            }
            StartCoroutine(TimeToCloseDoor());

        }
        else
        {
            StopCoroutine(TimeToCloseDoor());
            leftDoorPos = new Vector3(-4.1f, elevatorLeftDoors[floorNum].position.y, -1.25f);
            rightDoorPos = new Vector3(-4.1f, elevatorRightDoors[floorNum].position.y, 1.25f);

            if (elevatorRightDoors[floorNum].position == rightDoorPos)            
            {
                isDoorOpen = false;
            }
        }
    }

    public IEnumerator TimeToCloseDoor()
    {
        yield return new WaitForSeconds(5);
        ElevatorDoorState(false);
    }
    
    public void SetOnlyOneFloorToGo()
    {
        positionToGo = elevatorWayPoints[floorNum].position;
    }

    void DoorMoveState()
    {
        if (Vector3.Distance(elevatorTransform.position, positionToGo) == 0 && isfloorSelected)
        {
            isfloorSelected = false;
            ElevatorDoorState(true);
        }
        else if (Vector3.Distance(elevatorTransform.position, positionToGo) != 0 && isfloorSelected)
        {
            ElevatorDoorState(false);
        }

        elevatorLeftDoors[floorNum].position = Vector3.MoveTowards(elevatorLeftDoors[floorNum].position, leftDoorPos, Time.deltaTime);
        elevatorRightDoors[floorNum].position = Vector3.MoveTowards(elevatorRightDoors[floorNum].position, rightDoorPos, Time.deltaTime);
    }

    void ElevatorMove()
    {
        if (isDoorOpen == false)
        {
            elevatorTransform.position = Vector3.MoveTowards(elevatorTransform.position, positionToGo, elevatorVelocity * Time.deltaTime);
        }
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
        positionToGo = elevatorTransform.position;
        ElevatorDoorState(false);
    }

    void Update()
    {
        ElevatorMove();
        DoorMoveState();
    }
}