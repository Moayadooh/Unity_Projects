using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;        //Access to car rigid body
    public float forwardSpeed;  //Determine forward car speed
    public float sideWaySpeed;  //Determine side way car speed
    void Update()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);   //Go forward

        if (Input.GetKey("d"))   //Check if pressed key id 'd'
        {
            rb.AddForce(sideWaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  //Go to right side by 'd' key
        }
        if (Input.GetKey("a"))   //Check if pressed key id 'a'
        {
            rb.AddForce(-sideWaySpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);  //Go to left side by 'a' key
        }
    }
}
