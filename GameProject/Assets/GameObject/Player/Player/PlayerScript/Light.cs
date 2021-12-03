using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    private Vector3 lastVelocity;//���x�x�N�g��
    private Rigidbody rb;//Rigidbody�p
    public float light_speed = 50;  //���C�g��Ԃ̎��̃X�s�[�h
    public bool ischange = false;   //�U������̏��
    public bool Lightstatus = false; //���C�g���
    public bool direction = true;//�����Ă������ //ture�F�E   //false�F��

    private Vector3 start_pos;

    GameObject light;//���C�g�X�N���v�g
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


        if (StageScript.isLight_Flg == true)
        {

            if (targetObj.activeSelf == false)
            {
                rb.AddForce(new Vector3(0, 0, 0));
            }


            //if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetButtonDown("Light"))
            //{
            //    Debug.Log("�V�t�g������");
            //    Lightstatus = true;
            //    ischange = true;

            //}
            //else
            //{

            //}

            //if (Input.GetKey(KeyCode.RightArrow))
            //{
            //    direction = false;
            //    Debug.Log("�E");
            //}
            //if (Input.GetKey(KeyCode.D))
            //{
            //    direction = false;
            //    Debug.Log("�E");
            //}
            //if (Input.GetKey(KeyCode.LeftArrow))
            //{
            //    direction = true;
            //    Debug.Log("��");
            //}
            //if (Input.GetKey(KeyCode.A))
            //{
            //    direction = true;
            //    Debug.Log("��");
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

       
        
        this.lastVelocity = this.rb.velocity;//Rigidbody���g�p�����ړ��p

    }


    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Mirror")//���Ɠ���������
        {
            //if (rb.useGravity == false)
            //{
                Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//���˃x�N�g���v�Z
                this.rb.velocity = refrectVec;

        }
        else
        {
            ischange = false;
            script.LightStatus = false;

            targetObj.SetActive(false);
            targetobject.transform.position = targetObj.transform.position;
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
