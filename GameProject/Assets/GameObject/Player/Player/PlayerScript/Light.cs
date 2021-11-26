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

    GameObject light;//ライトスクリプト
    ChangePlayer script;

    GameObject stage;
    stage_test_script StageScript;

    Vector3 PlayerPos;

    public GameObject targetObj;
    public GameObject targetobject;

    void Start()
    {

        light = GameObject.Find("GameObject");
        script = light.GetComponent<ChangePlayer>();

        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();


        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (StageScript.isLight_Flg == true)
        {
            //if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetButtonDown("Light"))
            //{
            //    Debug.Log("シフトおした");
            //    Lightstatus = true;
            //    ischange = true;

            //}
            //else
            //{

            //}

            if (Input.GetKey(KeyCode.RightArrow))
            {
                direction = false;
                Debug.Log("右");
            }
            if (Input.GetKey(KeyCode.D))
            {
                direction = false;
                Debug.Log("右");
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                direction = true;
                Debug.Log("左");
            }
            if (Input.GetKey(KeyCode.A))
            {
                direction = true;
                Debug.Log("左");
            }

            if (Input.GetAxis("joystick_L") > 0)
            {
                direction = false;
            }
            else if (Input.GetAxis("joystick_L") < 0)
            {
                direction = true;
            }

        }



    }

    void FixedUpdate()
    {

        if (script.LightStatus == true)
        {
            if (Input.GetAxis("joystick_L") > 0)
            {
                 rb.useGravity = false;
                rb.AddForce(new Vector3(-light_speed, 0, 0));
            }
            else if (Input.GetAxis("joystick_L") < 0)
            {
                rb.useGravity = false;
                rb.AddForce(new Vector3(light_speed, 0, 0));

            }


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
            rb.useGravity = true;
        }


        if (coll.gameObject.tag == "Ground")
        {
            ischange = false;
            script.LightStatus = false;

            targetObj.SetActive(false);
            targetobject.transform.position = targetObj.transform.position;
        }



    }
}
