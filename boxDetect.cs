using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class boxDetect : MonoBehaviour {
    public UnityEvent onBoxDetected;
    public UnityEvent onBoxReleased; 
    public string color;
    public bool isPressed;
    
    
    
    private void OnTriggerEnter2D(Collider2D col) {
        boxProperties boxProps = col.GetComponent<boxProperties>();
        
        
        // currently the collider on the player is causing the else statement to 
        // trigger and it is turning the platepressed state off even though the
        // correct box is on the plate

        
        // maybe make 
        
        // maybe place this method in update function?
        if( boxProps ) {
            
            if( boxProps.boxColor == this.color ) {
                
                // this method will not work without this invoke method
                onBoxDetected.Invoke();
                //test.PlatePressed(); 
                isPressed = true; 
            }
            
        }
       
        {
            
        }
    }
    private void OnTriggerExit2D(Collider2D col) {
        boxProperties boxProps = col.GetComponent<boxProperties>();
        print(col.name);
        
        // currently the collider on the player is causing the else statement to 
        // trigger and it is turning the platepressed state off even though the
        // correct box is on the plate

        
        // maybe make 
        
        // maybe place this method in update function?
        if( boxProps ) {
            print("this should be a box: " + boxProps.name);
            if( boxProps.boxColor == this.color ) {
                print("still should be a box: " + boxProps.name);
                print("color of obj" + this.color);
                // this method will not work without this invoke method
                onBoxReleased.Invoke();
                isPressed = false; 
            }
            
        }
       
        {
            
        }
    }
}
// Start is called before the first frame update