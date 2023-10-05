using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 locationOffset;

    void FixedUpdate()
    {
        if(target.IsDestroyed()) return;
        
        Vector3 desiredPosition = target.position + target.rotation * locationOffset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        
    }
}