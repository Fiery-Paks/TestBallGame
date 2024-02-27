using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(h * speed, rb.velocity.y, v * speed);
        rb.AddForce(movement);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,500,0));
        }
        
    }
}
