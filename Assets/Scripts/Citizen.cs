using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : MonoBehaviour
{
    Transform player;   
    public float speed;
    float mouseX;

    void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }

    void PlayerRotate()
    {
        mouseX += Input.GetAxis("Mouse X");

        player.eulerAngles = new Vector3(0, mouseX);
    }
    void Awake()
    {
        player = transform;
    }
    void Update()
    {
        PlayerMove();
        PlayerRotate();
    }
    
}
