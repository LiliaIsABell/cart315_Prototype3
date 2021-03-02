using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punch : MonoBehaviour
{
    public Text pointsdisplay;

    int score = 0;

    public GameObject proximity1;
    public GameObject proximity2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = (proximity1.transform.position - proximity2.transform.position).magnitude;

        //textcomponent.text = "Distance" + distance;


        if (distance <= 0.7)
        {
            score = score + 1;
            pointsdisplay.text = "Points: " + score;
        }
    }
}
