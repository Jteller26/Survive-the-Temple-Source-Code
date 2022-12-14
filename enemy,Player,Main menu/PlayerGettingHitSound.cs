using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGettingHitSound : MonoBehaviour
{
    public AudioClip gettinghit;
    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy Bullet")
        {
            audio.PlayOneShot(gettinghit, 1F);
        }
    }
}
