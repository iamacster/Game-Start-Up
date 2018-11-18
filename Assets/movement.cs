using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float movementSpeed = 1f;
    Rigidbody rb;
    public bool onGround;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKey(KeyCode.A))
        {
            Vector3 newpos = new Vector3(rb.transform.position.x - movementSpeed, rb.transform.position.y, rb.transform.position.z);
            rb.transform.position = newpos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newpos = new Vector3(rb.transform.position.x + movementSpeed, rb.transform.position.y, rb.transform.position.z);
            rb.transform.position = newpos;
        }
        if (Input.GetKey(KeyCode.W))
        {

        }
    }

}
