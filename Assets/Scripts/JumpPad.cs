using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 20;
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
        if(rb == null) return;
        var collidingVelocity = rb.velocity;
        collidingVelocity.y = jumpForce;
        rb.velocity = collidingVelocity;
    }
}