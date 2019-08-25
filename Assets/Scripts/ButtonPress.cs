using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public int floor;

    void OnMouseOver()
    {
        GameManager.instance.Open_CloseElevatorPerMove();
    }

    private void Start()
    {
        GameManager.instance.destinyFloor = floor;
    }
}
