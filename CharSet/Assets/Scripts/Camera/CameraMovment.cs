using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed = 15f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

        Vector3 pos = new Vector3(0, smoothedPosition.x, 0);

        transform.position = smoothedPosition;
    }
}
