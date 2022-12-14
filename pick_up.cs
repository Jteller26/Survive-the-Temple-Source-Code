using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up : MonoBehaviour
{
    
    // Start is called before the first frame update

    public Transform grab;
    public Transform boxHolder;
    public float grabDistance;
    GameObject heldBox;


    // Update is called once per frame
    void Update()
    {
        //RaycastHit2D isGrabbed = Physics2D.Raycast(grab.position, Vector2.right * transform.localScale, grabDistance);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D isGrabbed = Physics2D.Raycast(grab.position, Vector2.left * transform.localScale, grabDistance);
            if( !isGrabbed.collider ) return;
            
            if( isGrabbed.collider.CompareTag( "box" ) ) {
                heldBox = isGrabbed.collider.gameObject;
                heldBox.transform.parent = boxHolder;
                heldBox.transform.position = boxHolder.position;
                heldBox.GetComponent<Rigidbody2D>().isKinematic = true;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if( heldBox ) {
                heldBox.transform.parent = null;
                heldBox.GetComponent<Rigidbody2D>().isKinematic = false;
            }
        }
    }
}
