using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float x;
    float z;

    public bool change = true;

    private Rigidbody rigidbody_;
    private Animator animator_;

    private Vector3 PlayerPos;

    Vector3 movingDirecion = Vector3.zero;

    //移動速度
    public float move_speed = 100.0f;

    GameObject maincamera;

    Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPos = GetComponent<Transform>().position;
        rigidbody_ = GetComponent<Rigidbody>();
        rigidbody_.constraints = RigidbodyConstraints.FreezeRotation;
        maincamera = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
        //// 左右キーを押した時の値（0～1）
        x = Input.GetAxis("Horizontal") * move_speed;

        PlayerPos = new Vector3(x, 0, 0);

       
        //↑キーで歩きモーションへ

        cameraPos = this.gameObject.transform.position;
        cameraPos.y += 5f;
        cameraPos.z += -20f;
        maincamera.transform.position = cameraPos;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            change = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            change =false;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            change = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            change = true;
        }

        if (PlayerPos.magnitude > 0.1)
        {
            transform.rotation = Quaternion.LookRotation(PlayerPos);
            transform.Translate(Vector3.forward * move_speed* Time.deltaTime);
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Debug.Log("当たった");
        }
    }

}
