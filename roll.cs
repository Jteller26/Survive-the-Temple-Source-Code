using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour
{
	private enum State
	{
		Normal,
		Rolling,
	}
	[SerializeField] private LayerMask dashLayerMask;
	public const float moveSpeed = 10f;
    public Rigidbody2D Rb;
    Vector3 move;
    private Vector3 rollDir;
    private float rollSpeed;

	private bool isDashDown;
	float dashAmount = 2f;
	private State state;

	private void Awake()
	{
		state = State.Normal;
	}

	void Update()
	{
		switch (state)
		{ 
			case State.Normal:

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

				if (Input.GetKeyDown(KeyCode.Q))
				{
					rollDir = move;
					rollSpeed = 70f;
					state = State.Rolling;
				}

				break; 
			case State.Rolling:
				float rollSpeedDrop = 5f;
				rollSpeed -= rollSpeed * rollSpeedDrop * Time.deltaTime;

				float rollSpeedMin = 50f;
				if (rollSpeed < rollSpeedMin)
				{
					state = State.Normal;
				}

				break;
		}
	}

	private void FixedUpdate()
    {
	    switch (state){
	    case State.Normal:
		    Rb.velocity = move * moveSpeed;

		    if (isDashDown)
		    {
			    Vector3 dashPosition = transform.position + move * dashAmount;
			    RaycastHit2D raycastHit2d = Physics2D.Raycast(transform.position, move, dashAmount, dashLayerMask);
			    if (raycastHit2d.collider != null)
			    {
				    dashPosition = raycastHit2d.point;
			    }
				    
			    Rb.MovePosition(dashPosition); 
			    isDashDown = false;
		    }
		    break; 
	    case State.Rolling:
		    Rb.velocity = rollDir * rollSpeed;
		    break;
	    }
    }

    
   
}
