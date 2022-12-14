using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int MAXHEALTH;
    public int currentHealth;
    public bool heal;
    public bool damage;

    void Start()
    {
        if(PlayerPrefs.GetInt("Health") == 0) {
            PlayerPrefs.SetInt("Health", MAXHEALTH);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (heal) {
            heal = false;
            gainHealth();
        }
        else if (damage) {
            damage = false;
            loseHealth();
        }
        currentHealth = getHealth();
        if (currentHealth <= 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public int getHealth() {
        return PlayerPrefs.GetInt("Health", 3);
    }

    public void loseHealth() {
        if (getHealth() > 0) {
            PlayerPrefs.SetInt("Health", getHealth() - 1);
        }
    }

    public void gainHealth() {
        if (getHealth() < 3) {
            PlayerPrefs.SetInt("Health", getHealth() + 1);
        }
    }

    
}
