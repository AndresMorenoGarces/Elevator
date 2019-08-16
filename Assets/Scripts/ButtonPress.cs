using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public int floor;
    void OnMouseEnter()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GameManager.instance.Open_CloseElevatorPerMove(floor);
        }
        
    }
}
