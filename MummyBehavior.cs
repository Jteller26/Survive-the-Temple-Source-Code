using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyBehavior : MonoBehaviour
{
    public float MoveSpeed;
    private Vector3 pos;
    private int index;
    private float round;
    private float roundtime = 5.0f;

    void Update()
    {
        roundtime -= Time.deltaTime;
        round = Random.Range(0, 360);
        index = Random.Range(0, 100);
        if (index <= 5)
        {
            this.transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime); 
        }
        else
        {
            //Make some noise
        }
        if (roundtime <= 0)
        {
            this.transform.Rotate(Vector3.forward * round * Time.time * MoveSpeed);
            roundtime = 5.0f;
        }
    }
}
