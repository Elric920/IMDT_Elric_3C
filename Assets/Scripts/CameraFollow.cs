using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smooth = 2.0f;

    Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.position;
    }

    private void Update()
    {
        Vector3 pos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, pos, smooth);
    }
}
