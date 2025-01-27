﻿using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float foewardForce = 2000f;
    public float sideWaysForce = 500f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, foewardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
