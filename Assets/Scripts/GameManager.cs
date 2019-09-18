using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //public List<int> elevatorFloorList = new List<int>();

    //internal void AddElevatorfloorToList(int floor)
    //{
    //    if (!elevatorFloorList.Contains(floor))
    //    {
    //        elevatorFloorList.Add(floor);           
    //    }
    //}
  
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
