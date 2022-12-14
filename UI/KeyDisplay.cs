using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyDisplay : MonoBehaviour
{
    public Image red;
    public Image blue;
    public Image yellow;
    public GameObject player;
    public bool playing = true;

    void Update() {
        
        KeyGrab keyInventory = player.GetComponent<KeyGrab>();
        if( !keyInventory ) return;
        
        if (keyInventory.ContainsKey(KeyScript.KeyColor.Yellow)) {
            yellow.color = Color.white;
            if (playing) {
                yellow.GetComponent<ParticleSystem>().Play();
                playing = false;
                print("effects got here");
            }
        }
        else {
            yellow.color = Color.black;
        }

        if (keyInventory.ContainsKey(KeyScript.KeyColor.Blue)) {
            blue.color = Color.white;
            if (!playing) {
                blue.GetComponent<ParticleSystem>().Play();
                playing = true;
            }
        }
        else {
            blue.color = Color.black;
        }

        if (keyInventory.ContainsKey(KeyScript.KeyColor.Red)) {
            red.color = Color.white;
            if (!playing) {
                red.GetComponent<ParticleSystem>().Play();
                playing = true;
            }
        }
        else {
            red.color = Color.black;
        }
        
    }
}
