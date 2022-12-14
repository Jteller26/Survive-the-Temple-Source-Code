using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBehavior : MonoBehaviour
{
    public float MoveSpeed;
    public Animator animator;
    private float StartToMove;
    private float round;
    private float StartToStop;

    void Start()
    {
        StartToMove = 3.0f;
        StartToStop = 4.0f;
    }

    void Update()
    {
        round = Random.Range(0, 180);
        StartToMove -= Time.deltaTime;
        if (StartToMove <= 0)
        {
            if (StartToStop >= 0)
            {
                animator.SetBool("Spider_Move", true);
                this.transform.Translate(Vector3.up * MoveSpeed * Time.deltaTime);
                StartToStop -= Time.deltaTime;
            }
            else
            {
                animator.SetBool("Spider_Move", false);
                this.transform.Rotate(Vector3.forward * round);
                StartToMove = 3.0f;
                StartToStop = 4.0f;
            }
        }
    }
}
