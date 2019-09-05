using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public List<int> floorList = new List<int>();

    internal void AddfloorToList(int floor)
    {
        if (!floorList.Contains(floor))
        {
            floorList.Add(floor);           
        }
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
