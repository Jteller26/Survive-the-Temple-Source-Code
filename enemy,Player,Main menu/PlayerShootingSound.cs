using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingSound : MonoBehaviour
{
    public AudioSource shooting;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            shooting.enabled = true;
        }
        else
        {
            shooting.enabled = false;
        }
    }
}
