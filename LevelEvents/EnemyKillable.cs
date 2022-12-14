using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyKillable : MonoBehaviour
{
    public GameObject killableEnemy;
    public UnityEvent enemyKill;
    // Start is called before the first frame update
    public void killme() {
        enemyKill.Invoke();
        Destroy( killableEnemy.gameObject);
    }
}
