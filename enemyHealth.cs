using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class enemyHealth : MonoBehaviour
{
    public float healthOfEnemy = 3f;
    public SpriteRenderer sprite;
    public UnityEvent enemyKill;
    public Animator animator;
    public bool alive = true;
    public bool isdead;
    public string deathAnimName;
    public AudioSource audioSource;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet" && healthOfEnemy > 0)
        {
            audioSource.Play();
            StartCoroutine(flashRed());
            healthOfEnemy -= 1f;
        }
        else if (collision.gameObject.tag == "Bullet" && healthOfEnemy <=0)
        {
            if (alive) {
                takeDamage();
                StartCoroutine(stayRed());
                enemyKill.Invoke();
                alive = false;
            }

        }
    }

    public void takeDamage() {
        if (healthOfEnemy > 0)
        {
            StartCoroutine(flashRed());
            healthOfEnemy -= 1f;
        }
        else if (healthOfEnemy <=0)
        {
            print(name + "triggered its death animation called" + deathAnimName);;
            animator.SetBool(deathAnimName, true);
            isdead = true;
            StartCoroutine(stayRed());
            Debug.Log("I'm dying");
        }
    }
    IEnumerator flashRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(.1f);
        sprite.color = Color.yellow;
    }
    IEnumerator stayRed()
    {
        sprite.color = Color.red;
        yield return new WaitForSeconds(.1f);
        sprite.color = Color.black;
    }
    public bool AliveState()
    {
        return isdead;
    }
    public void FinishDying()
    {
        Destroy(gameObject);
        Debug.Log("Dead");
    }
}