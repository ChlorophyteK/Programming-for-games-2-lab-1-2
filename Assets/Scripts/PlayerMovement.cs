using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Position player;
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;
    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        if (grounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(0, 10000 * Time.deltaTime, 0);
            }
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }
        
    }
}
