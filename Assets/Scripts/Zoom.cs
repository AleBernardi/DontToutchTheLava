using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Zoom : MonoBehaviour
{
 
    private Camera cam;
    private float targetZoom;
    private float zoomFactor = 10f;
    [SerializeField] private float zoomLerpSpeed = 10;
 
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        targetZoom = cam.fieldOfView;
    }
 
    // Update is called once per frame
    void Update()
    {
        float scrollData = Input.GetAxis("Mouse ScrollWheel");
        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 10, 30);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, targetZoom, Time.deltaTime * zoomLerpSpeed);
    }
}