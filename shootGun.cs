using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootGun : MonoBehaviour
{
    public Transform shotArea;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
    private void Shoot()
    {
        if (PlayerPrefs.GetInt("Ammo", 0) > 0) {
            PlayerPrefs.SetInt("Ammo", PlayerPrefs.GetInt("Ammo", 0) - 1);
            GameObject bullet = Instantiate(bulletPrefab, shotArea.position, shotArea.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(shotArea.right * bulletSpeed, ForceMode2D.Impulse);
        }
    }
}
