using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEnemy : MonoBehaviour
{
    public GameObject enemy_1;
    public GameObject enemy_2;
    public GameObject enemy_3;
    public GameObject enemy_4;
    public int num;
    public float x;
    public float y;
    Quaternion b = new Quaternion(0, 0, 0, 0);

    void Start()
    {
        num = Random.Range(8, 13);
        for (int index = 0; index < num; index++)
        {
            x = Random.Range(-10, 11);
            y = Random.Range(-5, 6);
            Vector2 pos = new Vector2(x, y);
            int enemy_num = Random.Range(1, 5);
            if (enemy_num == 1)
            {
                Instantiate(enemy_1, pos, b);
            }
            else if (enemy_num == 2)
            {
                Instantiate(enemy_2, pos, b);

            }
            else if (enemy_num == 3)
            {
                Instantiate(enemy_3, pos, b);
            }
            else if (enemy_num == 4)
            {
                Instantiate(enemy_4, pos, b);
            }
        }
    }
}
