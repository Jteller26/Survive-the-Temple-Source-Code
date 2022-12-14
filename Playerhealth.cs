using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
    public int health;
    public GameObject player;

    void Start()
    {
        health = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
