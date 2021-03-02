using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code from Fadrik on Youtube
//https://www.youtube.com/watch?v=UKqFvXaTuvQ


public class Player2Move : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

   

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.S)){

            this.gameObject.GetComponent<Transform>().Translate(Vector3.left * speed * Time.deltaTime);
            
        }

        if (Input.GetKey(KeyCode.W))
        {

            this.gameObject.GetComponent<Transform>().Translate(Vector3.right * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {

            this.gameObject.GetComponent<Transform>().Translate(Vector3.forward * speed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {

            this.gameObject.GetComponent<Transform>().Translate(Vector3.back * speed * Time.deltaTime);

        }
    }
}
