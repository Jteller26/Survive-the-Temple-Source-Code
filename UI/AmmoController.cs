using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoController : MonoBehaviour
{
    public TextMeshProUGUI count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count.text = getAmmo().ToString();
    }

    private int getAmmo() {
        return PlayerPrefs.GetInt("Ammo", 50);
    }
}
