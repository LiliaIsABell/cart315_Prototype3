using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour


{
    public GameObject body;
    public GameObject fist;

    public int scene;

    private void OnTriggerEnter(Collider Object)
    {
    
        if (Object.gameObject == fist)
        {
            
            SceneManager.LoadScene(scene);
        }

    }

}