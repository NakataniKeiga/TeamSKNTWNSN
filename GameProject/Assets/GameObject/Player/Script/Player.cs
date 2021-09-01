using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float x;

    float z;

    private Rigidbody rigidbody_;
    private Animator animator_;

    private Vector3 PlayerPos;
  
    //移動速度
    public float move_speed = 5.0f;

    GameObject maincamera;

    Vector3 cameraPos;
    ////発射バレット
    //public GameObject bullet_;

    public int Physical = 100;
    //
    public float offset_ = 1.0f;

    bool kk, swit;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPos = GetComponent<Transform>().position;
        animator_ = GetComponent<Animator>();
        rigidbody_ = GetComponent<Rigidbody>();
        rigidbody_.constraints = RigidbodyConstraints.FreezeRotation;

        maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        // 左右キーを押した時の値（0～1）
        x = Input.GetAxis("Horizontal");
        //Vector3 pos=
        Vector3 pos = transform.position;
        Vector3 rot_ = transform.localEulerAngles;
        Vector3 fward = transform.forward;
        //↑キーで歩きモーションへ


        PlayerPos = new Vector3(x, 0, z);

        if (PlayerPos.magnitude > 0.1)
        {
            transform.rotation = Quaternion.LookRotation(PlayerPos);
            transform.Translate(Vector3.forward * move_speed* Time.deltaTime);


            cameraPos = this.gameObject.transform.position;
            cameraPos.y += 5f;
            cameraPos.z += -20f;
            maincamera.transform.position = cameraPos;
         

        }

        //if (Input.GetKey(KeyCode.W))
        //{
        //    pos += fward * move_speed * Time.deltaTime;
        //}

        //transform.position = pos;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Debug.Log("当たった");
        }
    }

}
