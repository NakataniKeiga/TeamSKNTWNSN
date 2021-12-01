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
            h = CrossPlatformInputManager.GetAxis("pov_L_H");

            move_pos.x = transform.position.x;
            move_pos.y = h * transform.position.y;
            move_pos.z = transform.position.z;

            transform.position = move_pos;
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            v = CrossPlatformInputManager.GetAxis("Vertical");

        }
        else
        {
            v = CrossPlatformInputManager.GetAxis("pov_L_V");

            move_pos.x = v * transform.position.x;
            move_pos.y = transform.position.y;
            move_pos.z = transform.position.z;

            transform.position = move_pos;
        }


    }
}
