using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 3)
                transform.Translate(Vector3.right * 3);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (transform.position.x > -3)
                transform.Translate(Vector3.right * -3);
        }
    }
}
