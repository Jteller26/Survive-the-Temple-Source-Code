using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dash : MonoBehaviour
{
	[SerializeField] private LayerMask dashLayerMask;
	public const float moveSpeed = 10f;
    public Rigidbody2D Rb;
    Vector3 move;

	private bool isDashDown;
	float dashAmount = 2f;


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
		
		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			isDashDown = true;
		}

    }

    private void FixedUpdate()
    {
        Rb.velocity = move * moveSpeed;

    	if (isDashDown)
		{
			Vector3 dashPosition = transform.position + move * dashAmount;
			RaycastHit2D raycastHit2d = Physics2D.Raycast(transform.position, move, dashAmount, dashLayerMask);
			if (raycastHit2d.collider != null){
				dashPosition = raycastHit2d.point;
			}
			Rb.MovePosition(dashPosition);
			isDashDown = false;
		}
		
	}

    
   
}
