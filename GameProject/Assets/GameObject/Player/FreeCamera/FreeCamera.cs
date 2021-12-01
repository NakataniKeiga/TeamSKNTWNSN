using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FreeCamera : MonoBehaviour
{

    private Vector3 move_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = 0.0f;
        float v = 0.0f;

        if (Input.GetAxis("Horizontal") != 0)
        {
            h = CrossPlatformInputManager.GetAxis("Horizontal");
        }
        else
        {
            h = CrossPlatformInputManager.GetAxis("pov_H");
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            v = CrossPlatformInputManager.GetAxis("Vertical");

        }
        else
        {
            v = CrossPlatformInputManager.GetAxis("pov_V");
        }

        move_pos = v * Vector3.forward + h * Vector3.right;

        move_pos.y = move_pos.z;
        move_pos.z = 0.0f;
        transform.position = transform.position + move_pos;
    }
}
