using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    ElevatorMove elevatorMove = ElevatorMove.Stop;

    Elevator elevatorTemp = new Elevator();
    Citizen citizenTemp = new Citizen();

    public void Open_CloseElevatorPerMove()
    {
        if (elevatorTemp.ElevatorMove() == true)       
            elevatorTemp.CloseDoor();     
        else
            elevatorTemp.OpenDoor();
    }

     void ButtonMove()
    {
        if (elevatorTemp.ElevatorMove() == true)
        {
            elevatorMove = ElevatorMove.Move;
            elevatorTemp.ElevatorMove();
        }
        else
        {
            elevatorMove = ElevatorMove.Stop;
        }
    }

    void FloorSeleccioner()
    {
        
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

    void Start()
    {

    }

}
