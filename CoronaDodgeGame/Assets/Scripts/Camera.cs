using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerPos;
    private Vector3 cameraOffset;

    [Range(0.01f, 1.0f)]
    public float smoothSpeed = 0.5f;

    private void Start()
    {
        cameraOffset = transform.position - playerPos.position;
    }

    private void FixedUpdate()
    {
        Vector3 newPos = playerPos.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothSpeed);
    }
}
