using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.tag == "Obstacle")
        {
            movement.enabled = false;  //Stop player Movement
            FindObjectOfType<GameManager>().LoseTheGame();
        }
    }
}
