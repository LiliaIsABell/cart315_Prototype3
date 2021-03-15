using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Code from Fadrik on Youtube
//https://www.youtube.com/watch?v=UKqFvXaTuvQ


public class Player1Move : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    //Punching variables
    //
    //public string punchtag;

    public Text pointsdisplay;

    int score = 0;

    public GameObject fist;
    public GameObject target;

    // From Charles code
    public bool punching = false;



  


    // Update is called once per frame
    void Update()
    {
        //Movement code
        //
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

        //Punching code
        //
        float distance = (fist.transform.position - target.transform.position).magnitude;


        if (distance <= 0.7)
        {
            score += 1;
            pointsdisplay.text = "Points: " + score;

        }

        if (Input.GetKey(KeyCode.F))
        {
            StartCoroutine(Attack(0.15f, 3f, fist.transform.right));
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

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.gameObject.CompareTag(punchtag))
    //    {

    //        SceneManager.LoadScene(0);

    //    }
    //}
}
