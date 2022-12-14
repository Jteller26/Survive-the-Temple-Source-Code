using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class inventoryManager : MonoBehaviour
{
  public int AmmoCount;

  public bool hasKey;

  public bool hasPurpleKey; 

  public void PickupItem(GameObject item)
  {
    switch (item.tag)
    {
      
      case "Purple Key":
        hasPurpleKey = true;
        break; 
      case "Key":
        hasKey = true;
        break; 
      case "Ammo":
        AmmoCount += 15;
        break; 
      
    }
    //feel free to adjust ammount of ammo per pickup
    
  }
 
}
