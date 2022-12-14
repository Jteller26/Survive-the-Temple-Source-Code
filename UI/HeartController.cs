using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class HeartController : MonoBehaviour
{
    public GameObject[] hearts;

    public int currentHealth;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < getHealth()) {
            Animator heartAnimation = hearts[getHealth() - 1].GetComponent<Animator>();
            //hearts[getHealth() - 1].GetComponent<ParticleSystem>().Play();
            heartAnimation.Play("HeartBeatGain");
        }
        else if (currentHealth > getHealth()) {
            Animator heartAnimation = hearts[getHealth()].GetComponent<Animator>();
            heartAnimation.Play("HeartBeatLoss");
        }
        currentHealth = getHealth();

        if (getHealth() == 1) {
            Animator heartAnimation = hearts[0].GetComponent<Animator>();
            heartAnimation.Play("HeartBeatFinal");
        }
        else if (getHealth() > 1) {
            Animator heartAnimation = hearts[0].GetComponent<Animator>();
            heartAnimation.Play("HeartBeatNormal");
        }
        
    }

    public int getHealth() {
        return PlayerPrefs.GetInt("Health", 3);
    }
}
