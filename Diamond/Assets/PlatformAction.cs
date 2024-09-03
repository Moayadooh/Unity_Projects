using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAction : MonoBehaviour {

    public GameObject diamondLeft;
    public GameObject diamondRight;
    public GameObject diamondCenter;

    // Use this for initialization
    void Start ()
    {
        ChooseDiamon();
    }

    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.forward * -50 * Time.deltaTime);
        if (transform.position.z < -27)
        {
            transform.position = new Vector3(0, 0, 0);
            AllDiamonFalse();
            ChooseDiamon();
        }
	}
    void ChooseDiamon()
    {
        if (Random.value > 0.65)
            diamondLeft.SetActive(true);
        else if (Random.value > 0.33)
            diamondRight.SetActive(true);
        else
            diamondCenter.SetActive(true);
    }
    void AllDiamonFalse()
    {
        diamondLeft.SetActive(false);
        diamondRight.SetActive(false);
        diamondCenter.SetActive(false);
    }
}
