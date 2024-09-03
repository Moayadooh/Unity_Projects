using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOver;
    public Text result;
    public PlayerMovement movement;
    bool gameHasEnded = false;
    public void WinTheGame()
    {
        if (gameHasEnded == false)
        {
            gameOver.SetActive(true);
            result.text = "YOU WIN";
            movement.enabled = false;
            gameHasEnded = true;
        }
    }
    public void LoseTheGame()
    {
        if (gameHasEnded == false)
        {
            gameOver.SetActive(true);
            result.text = "YOU LOSE!!";
            movement.enabled = false;
            gameHasEnded = true;
        }
    }
}
