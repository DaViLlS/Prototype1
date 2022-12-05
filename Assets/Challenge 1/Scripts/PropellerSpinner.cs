using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinner : MonoBehaviour
{
    private float _plannerSpeed = 1000.0f;
    private void Update()
    {
        transform.Rotate(Vector3.back * _plannerSpeed * Time.deltaTime);
    }
}