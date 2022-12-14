using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelDoor : MonoBehaviour
{
    public float requiredNumOfPlates; 
    public bool unlocked = false; 
    private int _numPlatesPressed;

    public int numPlatesToPress;

    public void Unlock() {
        unlocked = true;
    }

    public void PlatePressed() {
        _numPlatesPressed++;

        if( _numPlatesPressed == requiredNumOfPlates ) {
            Unlock();
        }
    }

    public void PlateDepressed()
    {
        _numPlatesPressed--;
        unlocked = false; 
    }
}