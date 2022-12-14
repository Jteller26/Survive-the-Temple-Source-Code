using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    public GameObject bulletEnemy;
    public Animator animator;
    public float fireRate;
    float nextFire;
    public Transform player;
    public string attackAnimName;
    public AudioSource audioSource;

    void Start()
    {
      
        nextFire = Time.time;
    }

    void Update()
    {
        float dist = Vector2.Distance(transform.position, player.position);
        if (dist < 6)
        {
            TimeFire();
        }
    }

    void TimeFire()
    {
        bool isAlive = GetComponent<enemyHealth>().alive;
        
        if (isAlive) {
            if (Time.time > nextFire)
            {
                animator.SetTrigger(attackAnimName);
                audioSource.Play();
                Instantiate(bulletEnemy, transform.position, Quaternion.identity);
                nextFire = Time.time + fireRate;
            }
        }
    }
}