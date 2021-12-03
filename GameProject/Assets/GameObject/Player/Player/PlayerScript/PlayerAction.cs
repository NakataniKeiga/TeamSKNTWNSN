using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

  [RequireComponent(typeof(PlayerAnime))]

public class PlayerAction : MonoBehaviour
{
    bool Cameraflg = false;


    private PlayerAnime m_Anime;
    private Vector3 m_Move;
    private bool m_Jump;
    public bool change = true;
    private Vector3 start_pos;
    GameObject maincamera;
    Vector3 cameraPos;


    // Start is called before the first frame update
    void Start()
    {
        m_Anime = GetComponent<PlayerAnime>();

        maincamera = GameObject.Find("Main Camera");
        start_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if(start_pos.z != transform.position.z)
        {
            Vector3 result;

            result.x = transform.position.x;
            result.y = transform.position.y;
            result.z = start_pos.z;

            transform.position = result;

        }

        if (Cameraflg == false)
        {

            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump_joy");
            }


            cameraPos = this.gameObject.transform.position;
            cameraPos.y += 5f;
            cameraPos.z += -15f;
            maincamera.transform.position = cameraPos;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                change = false;
                Debug.Log("右");
            }
            if (Input.GetKey(KeyCode.D))
            {
                change = false;
                Debug.Log("右");
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                change = true;
                Debug.Log("左");
            }
            if (Input.GetKey(KeyCode.A))
            {
                change = true;
                Debug.Log("左");
            }

            if (Input.GetAxis("joystick_L_H") > 0)
            {
                change = false;
            }
            else if (Input.GetAxis("joystick_L_H") < 0)
            {
                change = true;
            }
        }
    }

    private void FixedUpdate()
    {
        float h;

        if (Input.GetAxis("Horizontal") != 0)
        {
            h = CrossPlatformInputManager.GetAxis("Horizontal");
        }
        else
        {
            h = CrossPlatformInputManager.GetAxis("joystick_L_H");
        }
       
        

        m_Move = h * Vector3.right;

        if (Input.GetKey(KeyCode.C)) m_Move *= 0.5f;

        bool crouch = Input.GetKey(KeyCode.C);
        m_Anime.Move(m_Move, crouch, m_Jump);
        m_Jump = false;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Debug.Log("当たった");
        }
        if (transform.parent == null && collision.gameObject.tag == "Move_Block")
        {

            var block = new GameObject();
            block.transform.parent = collision.gameObject.transform;
            transform.parent = block.transform;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (transform.parent != null && collision.gameObject.tag == "Move_Block")
        {
            transform.parent = null;
        }
    }
}
