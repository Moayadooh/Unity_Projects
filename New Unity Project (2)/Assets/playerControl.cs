﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float movev = Input.GetAxis("Vertical");
        Vector3 movePlay = new Vector3(moveH, 0.0f, movev);

        GetComponent<Rigidbody>().AddForce(movePlay * speed * Time.deltaTime);
    }
}
