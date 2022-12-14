using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public int attack;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<Playerhealth>().health -= attack;
            Destroy(bullet);
        }
    }
}
