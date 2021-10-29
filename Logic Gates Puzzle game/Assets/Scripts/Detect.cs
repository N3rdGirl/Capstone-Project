using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Detect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll)
    {
        Debug.Log("collided");
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Player");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
