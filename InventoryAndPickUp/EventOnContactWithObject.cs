using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnContactWithObject : MonoBehaviour
{
    public GameObject objectToContact;
    public GameObjectEvent itemPickup;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject == objectToContact) {
            itemPickup.Invoke(other.attachedRigidbody ? other.attachedRigidbody.gameObject : other.gameObject);
        }
    }
}
