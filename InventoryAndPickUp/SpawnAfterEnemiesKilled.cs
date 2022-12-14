using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpawnAfterEnemiesKilled : MonoBehaviour
{
    public int enemiesKilled = 0;
    public int enemiesKilledGoal;
    public GameObject item;

    private bool itemSpawned = false;

    private void Start() {
        item.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (enemiesKilled >= enemiesKilledGoal && !itemSpawned) {
            item.gameObject.SetActive(true);
            itemSpawned = true;
        }
    }

    //listener to enemy kill events.
    public void enemyKill() {
        enemiesKilled += 1;
    }
}
