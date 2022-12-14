using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector2 pos_1;
    public Vector2 pos_2;
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        pos_1 = player.transform.position;
        pos_2 = this.transform.position;
        float dis = (pos_1 - pos_2).magnitude;
        if(dis <= 10)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
