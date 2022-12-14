using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybullet : MonoBehaviour
{
    float move = 7f;
    public Rigidbody2D rb;
    GameObject player;
    Vector2 direction;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        direction = (player.transform.position - transform.position).normalized * move;
        rb.velocity = new Vector3(direction.x, direction.y);
        Destroy(gameObject, 3f);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerHP>().loseHealth();
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
