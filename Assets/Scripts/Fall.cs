using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fall : MonoBehaviour
{
    public SphereScript player1;
    public SphereScript player2;

    


    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y <= 0 && player1.score > player2.score)
        {
            SceneManager.LoadScene(5);

        }

        else if (transform.position.y <= 0 && player2.score > player1.score)
        {
            SceneManager.LoadScene(4);

        }

        else if (transform.position.y <= 0 && player2.score == player1.score)
        {
            SceneManager.LoadScene(1);
        }
    }
}
