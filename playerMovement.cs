using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

	public const float moveSpeed = 5f;
    public Rigidbody2D Rb;
    Vector3 move;




    void Update()
    {
		float moveX = 0f;
		float moveY = 0f;

		if (Input.GetKey(KeyCode.W)) 
		{
			moveY = +1f;
		}
		if (Input.GetKey(KeyCode.S)) 
		{
			moveY = -1f;
		}
		if (Input.GetKey(KeyCode.A)) 
		{
			moveX = -1f;
		}
		if (Input.GetKey(KeyCode.D)) 
		{
			moveX = +1f;
		}

		move = new Vector3(moveX, moveY).normalized;

    }

    private void FixedUpdate()
    {
        Rb.velocity = move * moveSpeed;		
	}

    
   
}
