using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{

    public Text diamondLeft;
    public Text timer;
    public Text gameOver;

    public GameObject platform;

    private int diamondCount = 10;
    private float timeLeft = 10.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        diamondLeft.text = "Diamond Left : " + diamondCount.ToString();

        timer.text = "Time Left : " + Mathf.Round(timeLeft);
        timeLeft = timeLeft- Time.deltaTime;

        if (timeLeft < 0)
        {
            Destroy(platform);
            gameOver.text = "You Lose!";
            Destroy(gameObject);
        }
        if (diamondCount == 0)
        {
            Destroy(platform);
            gameOver.text = "You Win!";
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "diamond")
            diamondCount--;
    }
}
