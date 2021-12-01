using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    //    float h;
    //    float v;

    //    // read inputs
    //    if (Input.GetAxis("Horizontal") != 0)
    //    {
    //        h = CrossPlatformInputManager.GetAxis("Horizontal");
    //    }
    //    else
    //    {
    //        h = CrossPlatformInputManager.GetAxis("joystick_L_H");
    //    }

    //    if (Input.GetAxis("Vertical") != 0)
    //    {
    //        v = CrossPlatformInputManager.GetAxis("Horizontal");
    //    }
    //    else
    //    {
    //        v = CrossPlatformInputManager.GetAxis("joystick_L_V");
    //        //v = 0.0f;
    //    }

    //    bool crouch = Input.GetKey(KeyCode.C);

    //    // calculate move direction to pass to character
    //    if (m_Cam != null)
    //    {
    //        // calculate camera relative direction to move:
    //        m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1, 0, 1)).normalized;
    //        m_Move = v * m_CamForward + h * m_Cam.right;
    //    }
    //    else
    //    {
    //        // we use world-relative directions in the case of no main camera
    //        m_Move = v * Vector3.forward + h * Vector3.right;
    //    }
    //}
}
