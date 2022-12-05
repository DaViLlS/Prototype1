using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private void Update()
    {
        if (gameObject.name == "Player1")
        {
            forwardInput = Input.GetAxis("WS");
            horizontalInput = Input.GetAxis("AD");
        }
        else
        {
            forwardInput = Input.GetAxis("UpDown");
            horizontalInput = Input.GetAxis("LeftRight");
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }
}
