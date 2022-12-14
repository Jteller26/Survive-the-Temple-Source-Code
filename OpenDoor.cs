using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
	[SerializeField]
	GameObject door;

	bool isOpened = false;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (!isOpened) 
		{
			isOpened = true;
			door.transform.position += new Vector3(0, 4, 0);
		}
	}
}
