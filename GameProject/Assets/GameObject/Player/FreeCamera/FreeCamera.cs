using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class FreeCamera : MonoBehaviour
{

    private Vector3 move_pos;

    private Vector3 start_set_pos;

    public GameObject player;

    public float MAX_X_R;
    public float MAX_X_L;
    public float MAX_Y_R;
    public float MAX_Y_L;

    // Start is called before the first frame update
    void Start()
    {
        start_set_pos = player.GetComponent<Transform>().position;
        start_set_pos.z = transform.position.z;
        transform.position = start_set_pos;
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

        if(transform.position.x + move_pos.x > MAX_X_R)
        {

            move_pos.x = (transform.position.x - MAX_X_R) * -1;
            
        }
        if (transform.position.x + move_pos.x < MAX_X_L)
        {

            move_pos.x = (transform.position.x - MAX_X_L) * -1;

        }
        if (transform.position.y + move_pos.y < MAX_Y_R)
        {

            move_pos.y = (transform.position.y - MAX_Y_R) * -1;

        }
        if (transform.position.y + move_pos.y > MAX_Y_L)
        {

            move_pos.y = (transform.position.y - MAX_Y_L) * -1;

        }


        transform.position = transform.position + move_pos;
    }
}
