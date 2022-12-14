using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public float speed = 3f;
    public Animator animator;
    private Transform target;
    [SerializeField] private float attackSpeed = 1f;
    private float attack;
    public string followAnimName;

    private void Update()
    {

        if (target != null)
        {
            if (GetComponent<enemyHealth>().alive) {
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            }
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (attackSpeed <= attack)
            {
                other.gameObject.GetComponent<PlayerHP>().loseHealth();
                attack = 0f;

            }
            else
            {
                attack += Time.deltaTime;
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = other.transform;
            animator.SetBool(followAnimName, true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            target = null;
            animator.SetBool(followAnimName, false);
        }
    }

}
