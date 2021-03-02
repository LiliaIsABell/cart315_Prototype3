using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code from Fadrik on Youtube
//https://www.youtube.com/watch?v=UKqFvXaTuvQ


public class Player1Move : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;



    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.DownArrow))
        {

            this.gameObject.GetComponent<Transform>().Translate(Vector3.left * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {

            this.gameObject.GetComponent<Transform>().Translate(Vector3.right * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            this.gameObject.GetComponent<Transform>().Translate(Vector3.forward * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {

            this.gameObject.GetComponent<Transform>().Translate(Vector3.back * speed * Time.deltaTime);

        }
    }
}
