using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Clamping : MonoBehaviour
{
    public Transform player;
    [SerializeField] float xMin = -1;
    [SerializeField] float xMax = 1;
    [SerializeField] float zMin = -1;
    [SerializeField] float zMax = 1;


    void FixedUpdate()
    {
        transform.position = new Vector3(
        Mathf.Clamp(player.position.x, xMin, xMax),
        transform.position.y,
        Mathf.Clamp(player.position.z, zMin, zMax));
    }
}
