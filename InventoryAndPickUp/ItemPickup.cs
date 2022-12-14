using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    public Inventory inventory;

    public void Pickup() {
        Destroy(this.gameObject);
    }
}
