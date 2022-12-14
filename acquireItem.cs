using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acquireItem : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            inventoryManager action = col.GetComponent<inventoryManager>();
            if (action)
            {
                action.PickupItem(gameObject);
                Destroy(gameObject);
            }
        }
    }
}
