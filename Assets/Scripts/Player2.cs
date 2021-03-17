using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code from Fadrik on Youtube
//https://www.youtube.com/watch?v=UKqFvXaTuvQ
// Punching code from Charles Rabbat, Prototype 2

public class Player2 : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    public GameObject fist;
    public GameObject target;

    // From Charles code
    public bool punching = false;


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

        //Punching code
        //
        if (Input.GetKey(KeyCode.F))
        {
            StartCoroutine(Attack(0.15f, 3f, Vector3.left));
        }
    }
    IEnumerator Attack(float time, float distance, Vector3 direction)

    {
        punching = true;
        float timer = 0.0f;
        direction.Normalize();
        while (timer <= time)
        {
            fist.transform.position = target.transform.position + (Mathf.Sin(timer / time * Mathf.PI) + 1.0f) * direction;
            yield return null;
            timer += Time.deltaTime;
        }
        fist.transform.position = target.transform.position;
        punching = false;
    }
}
