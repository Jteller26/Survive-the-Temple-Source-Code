using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmo : MonoBehaviour
{
    public int startAmmo;
    void Start()
    {
        PlayerPrefs.SetInt("Ammo", startAmmo);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getAmmo() {
        return PlayerPrefs.GetInt("Ammo", 3);
    }

    public void loseAmmo() {
        if (getAmmo() >= 0) {
            PlayerPrefs.SetInt("Ammo", getAmmo() - 1);
        }
    }

    public void gainAmmo(int num) {
        PlayerPrefs.SetInt("Ammo", getAmmo() + num);
    }
}
