using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyAttack : MonoBehaviour
{
    public GameObject mummy;
    public GameObject player;
    public Animator animator;
    public int health;
    public int attack;
    public Collision2D hit;
    private int life;
    private float attackTime;

    void Start()
    {
        life = 1;
        attackTime = 1.0f;
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
        if(attackTime <= 0)
        {
            animator.SetTrigger("Mummy_Attack");
            player.GetComponent<Playerhealth>().health -= attack;
            attackTime = Random.Range(1, 3);
        }
    }

    void Update()
    {
        OnCollisionEnter2D(hit);

        if (health <= 0 && life == 1)
        {
            health = 10;
            life -= 1;
        }
        if (health <= 0 && life == 0)
        {
            Destroy(mummy);
        }
    }
}
