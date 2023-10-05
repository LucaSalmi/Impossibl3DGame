using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    
    public float speed = 1.0f;
    public float jumpForce = 10;
    public float downwardForce = -5f;
    private Rigidbody _rigidBody;
    private bool _canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidBody.velocity.y < -.1f)
        {
            _rigidBody.AddForce(0,downwardForce*Time.deltaTime,0);
        }
        if (Input.GetButtonDown("Jump") && _canJump)
        {
            Jump();
            _canJump = false;
        }
        transform.Translate(0,0, speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.transform.CompareTag("Ground"))
        {
            _canJump = true;
        }
    }

    private void Jump()
    {
        _rigidBody.AddForce(0, jumpForce, 0, ForceMode.Impulse);
    }
}
