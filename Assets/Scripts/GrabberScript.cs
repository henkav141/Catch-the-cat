using System;
using UnityEngine;
using System.Collections;

public class GrabberScript : MonoBehaviour
{
    public GameObject basket;
    public GameObject player;
    public Transform HoldSlot;
    private bool attach;
    public Rigidbody2D BaskedRigidbody2D;
    public RaycastHit2D RaycastHit2;
    public float Distance = 2f;
    private bool grabbed;

    // Use this for initialization
    void Start () {
	    attach = true;
	}
	
	// Update is called once per frame
	void Update () {
	    if (!grabbed)
        {
            Physics2D.queriesStartInColliders = false;
            RaycastHit2 = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, Distance);

        }
        if (Input.GetKeyDown(KeyCode.F) && attach)
	    {
	        if (RaycastHit2.collider != null)
	        {
	            grabbed = true;
	        }
	        if (grabbed)
            {
                basket.transform.parent = player.transform;
                basket.transform.position = HoldSlot.position;
                attach = false;
                BaskedRigidbody2D.isKinematic = true;

            }
	    }
	    else if (Input.GetKeyDown(KeyCode.F) && !attach)
	    {
	        basket.transform.parent = new RectTransform();
	        BaskedRigidbody2D.isKinematic = false;
            attach = true;
	        grabbed = false;
	    }
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * Distance);
    }

}
