using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera staticCamera;     
    public Camera followCamera;     
    public Camera topDownCamera; 

    private Camera activeCamera; 
    void Start()
    {
        ActivateCamera(staticCamera);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivateCamera(staticCamera);   // 切换到静态相机
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivateCamera(followCamera);   // 切换到跟随相机
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivateCamera(topDownCamera);  // 切换到自上而下相机
        }
    

    }


void ActivateCamera(Camera cameraToActivate)
    {
        staticCamera.gameObject.SetActive(false);
        followCamera.gameObject.SetActive(false);
        topDownCamera.gameObject.SetActive(false);

        cameraToActivate.gameObject.SetActive(true);
        activeCamera = cameraToActivate;
    }
}