using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera frontCamera;
    public Camera sideCamera;
    public Camera topCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableCamera(frontCamera);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableCamera(sideCamera);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EnableCamera(topCamera);
        }
    }

    void EnableCamera(Camera targetCamera)
    {
        frontCamera.enabled = false;
        sideCamera.enabled = false;
        topCamera.enabled = false;
        targetCamera.enabled = true;
    }
}