using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventOnTriggerContact : MonoBehaviour {
	public GameObjectEvent onMadeContactWithOther;
	public GameObjectEvent onLostContactWithOther;
	
	public void OnTriggerEnter2D( Collider2D other ) {
		onMadeContactWithOther.Invoke( other.attachedRigidbody ? other.attachedRigidbody.gameObject : other.gameObject );
	}
	
	public void OnTriggerExit2D( Collider2D other ) {
		onLostContactWithOther.Invoke( other.attachedRigidbody ? other.attachedRigidbody.gameObject : other.gameObject );
	}
}
