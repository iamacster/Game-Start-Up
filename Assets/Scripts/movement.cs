using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float movementSpeed = 1f;
    public float jumpForce = 1f;
    public bool onGround;


    Rigidbody rb;
    Vector3 jump;


	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 1f, 0f);
    }
    private void OnCollisionStay(Collision collision)
    {
        onGround = true;
    }
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
        if (Input.GetKeyDown(KeyCode.W))
        {
            if(onGround)
            {
                rb.velocity = jump * jumpForce;
                GetComponent<SphereCollider>().enabled = false;
                onGround = false;
                GetComponent<SphereCollider>().enabled = true;
            }
        }
    }

}
