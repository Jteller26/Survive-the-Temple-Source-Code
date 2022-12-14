using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
	public float health;

	private void onCollisionEnter2D(Collider2D col)
	{
		GameObject whatHit = col.gameObject;
		if (whatHit.CompareTag("Untagged"))
		{
			health -= 10f;
		}
    }
}
