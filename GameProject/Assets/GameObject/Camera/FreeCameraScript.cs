using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FreeCameraScript : MonoBehaviour
{

    private Vector3 move_pos;
    public bool camera_flg = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float h;
        float v;

        // read inputs
        if (Input.GetAxis("Horizontal") != 0)
        {
            h = CrossPlatformInputManager.GetAxis("Horizontal");
        }
        else
        {
            h = CrossPlatformInputManager.GetAxis("joystick_R_H");
        }

        if (Input.GetAxis("Vertical") != 0)
        {
            v = CrossPlatformInputManager.GetAxis("Horizontal");
        }
        else
        {
            v = CrossPlatformInputManager.GetAxis("joystick_R_V");

        }

        move_pos = v * Vector3.forward + h * Vector3.right;

        move_pos.y = move_pos.z;
        move_pos.z = 0.0f;
        transform.position = transform.position + move_pos;


    }
}
