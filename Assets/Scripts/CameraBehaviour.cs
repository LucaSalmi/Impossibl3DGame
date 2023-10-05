using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 locationOffset;

   private void LateUpdate()
    {
        if(target.IsDestroyed()) return;

        Vector3 targetPosition = target.position + new Vector3(0, locationOffset.y, locationOffset.z);
        transform.position = targetPosition;
    }
}