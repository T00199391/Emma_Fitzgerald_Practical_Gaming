﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform target;
    public Vector3 offset;
    public bool useOffsetValues;
    public float rotateSpeed;
    public Transform pivot;

    // Use this for initialization
    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position - transform.position;
        }

        pivot.transform.position = target.transform.position;
        pivot.transform.parent = null;

        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        pivot.transform.position = target.transform.position;
        //Get the x position of the mouse and rotate the target
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        pivot.Rotate(0, horizontal, 0);

        //Move the camera based on the current rotation  of the target and the original offset
        float desiredYAngle = pivot.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        transform.LookAt(target.transform);
    }
}
