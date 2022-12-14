using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGrab : MonoBehaviour
{
    private List<KeyScript.KeyColor> keyList;

    void Awake()
    {
        keyList = new List<KeyScript.KeyColor>();
    }

    void AddKey(KeyScript.KeyColor keyColor)
    {
        Debug.Log("Addeed key: " + keyColor);
        keyList.Add(keyColor);
    }
    
    void RemoveKey(KeyScript.KeyColor keyColor)
    {
        keyList.Remove(keyColor);
    }

    public bool ContainsKey(KeyScript.KeyColor keyColor)
    {
        return keyList.Contains(keyColor);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        KeyScript key = collision.GetComponent<KeyScript>();
        if (key != null)
        {
            AddKey(key.GetKeyColor());
            Destroy(key.gameObject);
        }

        KeyDoor keyDoor = collision.GetComponent<KeyDoor>();
        if (keyDoor != null)
        {
            if (ContainsKey(keyDoor.GetKeyColor()))
            {
                RemoveKey(keyDoor.GetKeyColor());
                keyDoor.OpenDoor();
            }
        }
    }
    

}
