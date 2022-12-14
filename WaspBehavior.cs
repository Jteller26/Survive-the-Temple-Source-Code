using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaspBehavior : MonoBehaviour
{
    public float MoveSpeed;
    public float AddSpeed;
    private float StartToMove;
    private float round;
    private float StartToStop;

    void Start()
    {
        StartToMove = 3.0f;
        StartToStop = 1.3f;
    }

    // Update is called once per frame
    void Update()
    {
        round = Random.Range(0, 180);
        StartToMove -= Time.deltaTime;
        if (StartToMove <= 0)
        {
            if (StartToStop >= 0)
            {
                this.transform.Translate(Vector3.up * MoveSpeed * Time.deltaTime);
                StartToStop -= Time.deltaTime;
                MoveSpeed += AddSpeed;
            }
            else
            {
                this.transform.Rotate(Vector3.forward * round);
                StartToMove = 3.0f;
                StartToStop = 1.3f;
                MoveSpeed = 0;
            }
        }
    }
}
