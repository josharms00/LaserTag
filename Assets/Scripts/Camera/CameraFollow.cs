using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player, cam;            // The position that that camera will be following.
    public float smoothing = 1f;        // The speed with which the camera will be following.
    Vector3 offset;                     // The initial offset from the target.

    float MouseX, MouseY;

    void Start ()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        // Calculate the initial offset.
        offset = transform.position - player.position;
    }


    void FixedUpdate ()
    {
        MouseX += Input.GetAxis("Mouse X");
        MouseY -= Input.GetAxis("Mouse Y");
        MouseY = Mathf.Clamp(MouseY, -35, 60);

        transform.LookAt(cam);

        cam.rotation = Quaternion.Euler(MouseY, MouseX, 0);
        player.rotation = Quaternion.Euler(0, MouseX, 0);

        // Create a postion the camera is aiming for based on the offset from the target.
        // Vector3 targetCamPos = player.position + offset;

        // // Smoothly interpolate between the camera's current position and it's target position.
        // transform.position = targetCamPos;
    }
}
