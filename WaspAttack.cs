using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaspAttack : MonoBehaviour
{
    public GameObject wasp;
    public GameObject player;
    public int health;
    public int attack;
    public Collision2D hit;
    private float TotalAttackTime;
    private float OnceAttackTime;
    private int index;
    
    void Start()
    {
        TotalAttackTime = 2.0f;
        OnceAttackTime = 0.5f;
        index = 1;
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
        TotalAttackTime -= Time.deltaTime;
        if (TotalAttackTime <= 0)
        {
            OnceAttackTime -= Time.deltaTime;
            if (OnceAttackTime <= 0)
            {
                player.GetComponent<Playerhealth>().health -= attack;
                index += 1;
                OnceAttackTime = 0.5f;
                if (index == 3)
                {
                    TotalAttackTime = 3.0f;
                    index = 1;
                }
            }
        }
    }

    void Update()
    {
        OnCollisionEnter2D(hit);

        if(health <= 0)
        {
            Destroy(wasp);
        }
    }
}
