using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    public bool moves = false;
    public float movementSpeed = 0.035f;
    public float upperMovementLimit = 1.5f;
    public float lowerMovementLimit = -0.2f;

    private IEnumerator OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }

    void FixedUpdate()
    {
        MoveUpAndDown();
    }

    private void MoveUpAndDown()
    {
        if (transform.position.y > upperMovementLimit || transform.position.y < lowerMovementLimit)
        {
            movementSpeed = -movementSpeed;
        }

        if (moves)
        {
            transform.Translate(0, movementSpeed, 0);
        }
    }
}