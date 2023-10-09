using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    
    public float forwardSpeed = 1.0f;
    public float jumpForce = 10;
    public float downwardForce = -5f;
    private Rigidbody _rigidBody;
    // Start is called before the first frame update
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        var playerVelocity = _rigidBody.velocity;
        if (playerVelocity.y < -.1f)
        {
            _rigidBody.AddForce(0,downwardForce*Time.deltaTime,0);
        }

        playerVelocity.z = forwardSpeed;
        _rigidBody.velocity = playerVelocity;
    }
    // Update is called once per frame
    private void Update()
    {
        
        if (Input.GetButton("Jump") && IsTouchingGround())
        {
            Jump();
        }

    }

    private bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        var tr = transform;
        return Physics.CheckBox(tr.position, tr.lossyScale/1.99f, tr.rotation, layerMask);
    }

    private void Jump()
    {
        var playerVelocity = _rigidBody.velocity;
        playerVelocity.y = jumpForce;
        _rigidBody.velocity = playerVelocity;
        _rigidBody.angularVelocity = new Vector3(2,0,0);
    }
}
