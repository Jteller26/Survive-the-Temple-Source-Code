using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienAttack : MonoBehaviour
{
    public GameObject alien;
    public GameObject player;
    public GameObject bullet;
    public int health;
    public Collision2D hit;
    public Transform shot;
    public float speed;
    private float attackTime;

    void Start()
    {
        attackTime = 0.5f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CauseDamage(player);
        }
    }

    void CauseDamage(GameObject player)
    {
        attackTime -= Time.deltaTime;
        if (attackTime <= 0)
        {
            GameObject shootingBullet = Instantiate(bullet, shot.position, shot.rotation);
            Rigidbody2D blt = bullet.GetComponent<Rigidbody2D>();
            blt.AddForce(shot.right * speed, ForceMode2D.Impulse);
            attackTime = Random.Range(0.5f, 2f);
        }
    }
    void Update()
    {
        OnCollisionEnter2D(hit);

        if (health <= 0)
        {
            Destroy(alien);
        }
    }
}
