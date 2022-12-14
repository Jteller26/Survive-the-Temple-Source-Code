using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    public float health = 0f;
    [SerializeField] private float maxHealth = 100f;

    private void Start()
    {
        health = maxHealth;
    }

    public void UpdateHealth(float pace)
    {
        health += pace;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            Destroy(gameObject, 5f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
