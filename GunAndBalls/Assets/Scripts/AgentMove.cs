using UnityEngine;
using UnityEngine.UI;

public class AgentMove : MonoBehaviour
{

    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Text stat;
    UnityEngine.AI.NavMeshAgent agent;

    private float distance;
    private int goBack = 1;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = target1.position;
    }
    void Update()
    {
        if (goBack == 1)
        {
            if (transform.position.x == target1.position.x && transform.position.z == target1.position.z)
            {
                agent.destination = target2.position;
            }
            else if (transform.position.x == target2.position.x && transform.position.z == target2.position.z)
            {
                agent.destination = target3.position;
            }
            else if (transform.position.x == target3.position.x && transform.position.z == target3.position.z)
            {
                goBack = 2;
            }
        }
        else if (goBack == 2)
        {
            if (transform.position.x == target3.position.x && transform.position.z == target3.position.z)
            {
                agent.destination = target2.position;
            }
            else if (transform.position.x == target2.position.x && transform.position.z == target2.position.z)
            {
                agent.destination = target1.position;
            }
            else if (transform.position.x == target1.position.x && transform.position.z == target1.position.z)
            {
                goBack = 3;
            }
        }
        else
        {
            if (transform.position.x == target1.position.x && transform.position.z == target1.position.z)
            {
                agent.destination = target3.position;
            }
            else if (transform.position.x == target3.position.x && transform.position.z == target3.position.z)
            {
                stat.text = "You Lose!";
            }
        }
    }
}
