using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBehavior : MonoBehaviour
{
    public GameObject back;
    public float MoveSpeed;
    public float BackSpeed;
    private float movetime;
    private float round;
    private Vector2 limit;

    void Start()
    {
        movetime = 2.0f;
    }
    void Update()
    {
        movetime -= Time.deltaTime;
        round = Random.Range(0, 360);
        if(movetime <= 0)
        {
            this.transform.Translate(Vector2.up * Time.time * MoveSpeed);
            this.transform.Rotate(Vector3.forward * round * Time.time * MoveSpeed);
            movetime = Random.Range(2, 4);
        }
        limit = this.transform.position;
        if (limit.x >= 10 || limit.x <= -10 || limit.y >= 10 || limit.y <= -10)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, back.transform.position, BackSpeed);
        }
    }
}
