using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    void OnMouseEnter()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            GameManager.instance.Open_CloseElevatorPerMove();
        }
    }
}
