using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private KeyScript.KeyColor keyColor;


    public KeyScript.KeyColor GetKeyColor()
    {
        return keyColor;
    }

    public void OpenDoor()
    {
    	gameObject.SetActive(false);
    }
}
