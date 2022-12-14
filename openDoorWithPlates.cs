using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class openDoorWithPlates : MonoBehaviour
{
    public float requiredNumOfPlates; 
    public bool unlocked = false; 
    public float numPlatesPressed;

    public UnityEvent enableSceneChanger; 
    //private Collider _invisibleWall; 
    
    public void Unlock() {
        unlocked = true;
    }

    public void PlatePressed() {
        numPlatesPressed++;

        if( numPlatesPressed == requiredNumOfPlates ) {
            // unlocked is purely for testing as the invoke takes care of the scene change
            Unlock();
            enableSceneChanger.Invoke();
           // _invisibleWall.isTrigger = true; 
        }
    }

    public void PlateDepressed()
    {
        numPlatesPressed--;
        unlocked = false; 
    }
    
}
