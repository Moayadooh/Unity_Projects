using UnityEngine;
using UnityEngine.UI;

public class GameResult : MonoBehaviour
{
    public PlayerMovement movement;  //Access to PlayerMovement script
    public Text result;              //Access to result text
    public Text scoreText;           //Access to score text
    int score;
    bool gameHasEnded = false;

    void Start()
    {
        score = 0;  //Initialize total score
        scoreText.text = "Current Score : " + score;  //Display current score
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Obstacle")//Check if car collide with obstacle
        {
            if (!gameHasEnded)             //Check if game has ended
            {
                movement.enabled = false;  //Stop player movement
                result.text = "YOU LOSE!!";//Display 'YOU LOSE!!' statement
                scoreText.text = "";       //Remove score text
                gameHasEnded = true;
            }
        }
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (!gameHasEnded)      //Check if game has ended
        {
            if (col.gameObject.tag == "Ball")   //Check if car collide with ball
            {
                col.gameObject.SetActive(false);//Hide the ball
                score+=10;                        //Increase total score by 1
                scoreText.text = "Current Score : " + score;  //Display current score
            }
            if (col.gameObject.tag == "Finish")  //Check if car collide with end box
            {
                movement.enabled = false;                 //Stop player movement
                result.text = "YOU WIN!!";                //Display 'YOU WIN!!' statement
                scoreText.text = "Final Score : " + score;//Display final score
                gameHasEnded = true;
            }
        }
    }
}
