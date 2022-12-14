using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine;

public class levelTwoComplete : MonoBehaviour
{
    public int sceneBuildIndex;
    private bool unlocked;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        
        
        print("Trigger Entered");

        if(other.tag == "Player" && unlocked)
        {
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Open()
    {
        unlocked = true; 
    }
}
