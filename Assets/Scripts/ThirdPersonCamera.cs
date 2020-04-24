using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    

    private const float Y_ANGLE_MIN = -10.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 0.0f;
    private float currentX = 90.0f;
    private float currentY = 0.0f;

    private void Start(){
        camTransform = transform;
        cam = Camera.main;
        Cursor.visible = false;
    }

    private void Update(){
        if(!PauseMenu1.GameIsPaused){
            currentX += Input.GetAxis("Mouse X");
            currentY += Input.GetAxis("Mouse Y");
        }
        //currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }

    private void LateUpdate(){
        Vector3 dir = new Vector3(10, 5, distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}