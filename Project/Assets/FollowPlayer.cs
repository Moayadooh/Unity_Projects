using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;  //Access to player position
    public Vector3 offset;    //Determine the distance between car and camera
    void Update()
    {
        transform.position = player.position + offset;  //Change camera position
    }
}
