using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform[] elevatorWayPoints;
    public Transform elevator;
    public Transform doorOne;
    public int destinyFloor = 0;

    Elevator elevatorTemp = new Elevator();
    
    public void Open_CloseElevatorPerMove()
    {
        if (elevatorTemp.ElevatorMove(destinyFloor) == true)       
            elevatorTemp.CloseDoor();     
        else
            elevatorTemp.OpenDoor();
    }

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
