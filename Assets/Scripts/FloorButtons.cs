using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FloorButtons : MonoBehaviour
{
    public List<int> buttonList;
    public int[] floorNumbers = new int[7];


    void Start()
    {
        buttonList = new List<int>(floorNumbers);
        buttonList.Sort();
    }
}
