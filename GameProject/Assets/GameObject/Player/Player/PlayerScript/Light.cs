using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private Vector3 lastVelocity;//速度ベクトル
    private Rigidbody rb;//Rigidbody用
    public float light_speed = 50;  //ライト状態の時のスピード
    public bool ischange = false;   //振り向きの状態
    public bool Lightstatus = false; //ライト状態
    public bool direction = true;//向いている方向 //ture：右   //false：左

    public float LimitSpeed = 100;


    private Vector3 start_pos;
    GameObject lightcamera;

    GameObject light;//ライトスクリプト
    ChangePlayer script;

    GameObject stage;
    stage_test_script StageScript;

    //光状態の上の判定をとるために必要
    GameObject CollisionObject;
    Collisiondetection collisonobject;

    Vector3 PlayerPos;
    Vector3 cameraPos;


    public GameObject targetObj;
    public GameObject targetobject;

    void Start()
    {

        light = GameObject.Find("ChangePlayer");
        script = light.GetComponent<ChangePlayer>();

        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();

        //光状態上
        CollisionObject = GameObject.Find("CollisionLight");
        collisonobject = CollisionObject.GetComponent<Collisiondetection>();

        lightcamera = GameObject.Find("LightCamera");

        start_pos = transform.position;

        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (start_pos.z != transform.position.z)
        {
            Vector3 result;

            result.x = transform.position.x;
            result.y = transform.position.y;
            result.z = start_pos.z;

            transform.position = result;
        
        }
        cameraPos = this.gameObject.transform.position;
        cameraPos.y += 5f;
        cameraPos.z += -30f;
        lightcamera.transform.position = cameraPos;

        if (StageScript.isLight_Flg == true)
        {

            if (targetObj.activeSelf == false)
            {
                //rb.AddForce(new Vector3(0, 0, 0));
            }


            //if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetButtonDown("Light"))
            //{
            //    Debug.Log("シフトおした");
            //    Lightstatus = true;
            //    ischange = true;

            //}
            //else
            //{

            //}

            //if (Input.GetKey(KeyCode.RightArrow))
            //{
            //    direction = false;
            //    Debug.Log("右");
            //}
            //if (Input.GetKey(KeyCode.D))
            //{
            //    direction = false;
            //    Debug.Log("右");
            //}
            //if (Input.GetKey(KeyCode.LeftArrow))
            //{
            //    direction = true;
            //    Debug.Log("左");
            //}
            //if (Input.GetKey(KeyCode.A))
            //{
            //    direction = true;
            //    Debug.Log("左");
            //}

            //if (Input.GetAxis("joystick_L") > 0)
            //{
            //    direction = false;
            //}
            //else if (Input.GetAxis("joystick_L") < 0)
            //{
            //    direction = true;
            //}

        }


        //移動制限
        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.1f, 0, 0);
        }


    }

    void FixedUpdate()
    {

        if (Input.GetAxis("joystick_L_H") < 0)
        {
            rb.useGravity = false;
            rb.AddForce(new Vector3(-light_speed, 0, 0));
        }
        else if (Input.GetAxis("joystick_L_H") > 0)
        {
            rb.useGravity = false;
            rb.AddForce(new Vector3(light_speed, 0, 0));

        }

       
        
        this.lastVelocity = this.rb.velocity;//Rigidbodyを使用した移動用

    }

    

    void OnCollisionEnter(Collision coll)
    {

        if (coll.gameObject.tag == "Mirror")//鏡と当たった時
        {
            //if (rb.useGravity == false)
            //{
                  Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
                this.rb.velocity = refrectVec;

        }
        else
        {
            if (collisonobject.UpCollision == true)
            {


            }
            else
            {

            ischange = false;
            script.LightStatus = false;

            targetObj.SetActive(false);
            targetobject.transform.position = targetObj.transform.position;

            }
            
        }



        //if (coll.gameObject.tag == "Ground")
        //{
        //    ischange = false;
        //    script.LightStatus = false;

        //    targetObj.SetActive(false);
        //    targetobject.transform.position = targetObj.transform.position;
        //}



    }
}
