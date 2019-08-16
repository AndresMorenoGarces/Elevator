using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform[] elevatorWayPoints;
    public Transform doorOne;


    Elevator elevatorTemp = new Elevator();
    
    public void Open_CloseElevatorPerMove(int _destinyFloor)
    {
        if (elevatorTemp.ElevatorMove(_destinyFloor) == true)       
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
