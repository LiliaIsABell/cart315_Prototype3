using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereScript : MonoBehaviour

   
{
    public GameObject sphere;
    public GameObject collisionObject;

    public Text pointsdisplay;
    int score = 0;


    private void OnTriggerEnter(Collider Object)
    {
        if (sphere.tag == collisionObject.tag)
        {
            score += 1;
            pointsdisplay.text = "Points: " + score;
        }
    }
}
