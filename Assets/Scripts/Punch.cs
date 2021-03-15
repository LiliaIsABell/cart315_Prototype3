using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Punch : MonoBehaviour
{

    public string punchtag;

    public Text pointsdisplay;

    int score = 0;

    public GameObject fist;
    public GameObject target;

    // From Charles code
    public bool punching = false;


    // Update is called once per frame
    void FixedUpdate()
    {
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


    // From Charles code
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

private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag(punchtag))
        {

            SceneManager.LoadScene(0);

        }
    }
}
