using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 1.0f;
    public float jumpForce = 10;

    private bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            Jump();
            canJump = false;
        }
        transform.Translate(0,0, speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.transform.CompareTag("Ground"))
        {
            canJump = true;
        }
    }

    private void Jump()
    {
        var rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(0, jumpForce, 0, ForceMode.Impulse);
    }
}
