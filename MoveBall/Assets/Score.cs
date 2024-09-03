using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int count;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        CountText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "item")
        {
            col.gameObject.SetActive(false);
            count = count + 1;
            CountText();
        }
    }
    void CountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
