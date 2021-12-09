using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class CameraControl : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject lightCamera;
    public GameObject freeCamera;

    public GameObject lightball;

    // Start is called before the first frame update
    void Start()
    {
        lightCamera.SetActive(false);
        freeCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Light"))
        {
            lightCamera.SetActive(true);
            mainCamera.SetActive(false);
        }
        else if (lightball.activeSelf == false)
        {
            lightCamera.SetActive(false);
            mainCamera.SetActive(true);
        }
        if (Input.GetButtonDown("CameraChenge"))
        {
            if (lightCamera.activeSelf == false)
            {
                if (freeCamera.activeSelf == true)
                {
                    mainCamera.SetActive(true);
                    freeCamera.SetActive(false);
                }
                else if (mainCamera.activeSelf == true)
                {
                    mainCamera.SetActive(false);
                    freeCamera.SetActive(true);
                }
            }
        }
          

    }
}
