using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAttack : MonoBehaviour
{
    public GameObject spider;
    public GameObject Player;
    public Animator animator;
    public int health;
    public int attack;
    public int toxic;
    public Collision2D hit;
    private float attackTime;
    private float toTime;

    void Start()
    {
        attackTime = 2.0f;
        toTime = 1.0f;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CauseDamage(Player);
        }
    }

    void CauseDamage(GameObject player)
    {
        attackTime -= Time.deltaTime;
        if (attackTime <= 0)
        {
            animator.SetTrigger("Spider_Attack");
            player.GetComponent<Playerhealth>().health -= attack;
            if(toTime >= 0)
            {
                player.GetComponent<Playerhealth>().health -= toxic;
                toTime -= Time.deltaTime;
            }
            else
            {
                attackTime = Random.Range(2.0f, 3f);
                toTime = 1.0f;
            }
            
        }
    }

    void Update()
    {
        OnCollisionEnter2D(hit);

        if(health <= 0)
        {
            animator.SetBool("Spider_Died", true);
            Destroy(spider);
        }
    }
}
