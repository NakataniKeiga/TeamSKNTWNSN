using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    private Vector3 lastVelocity;//���x�x�N�g��
    private Rigidbody rb;//Rigidbody�p
    public float light_speed = 50;
    public bool ischange = false;
    public bool liftstatus = false;

    GameObject player;
    Player script;

    GameObject stage;
    stage_test_script StageScript;


    Vector3 PlayerPos;

    public GameObject targetObj;

    void Start()
    {

        player = GameObject.Find("moc_player");
        script = player.GetComponent<Player>();

        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();


        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (StageScript.isLight_Flg == true)
        {
            if (ischange ==false)
            {

                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    liftstatus = true;
                    ischange = true;


                }
            }

        }

    }

    void FixedUpdate()
    {
        if (script.change == true)
        {
                if (liftstatus == true)
                {
                rb.useGravity = false;
                liftstatus = false;
                rb.AddForce(new Vector3(-light_speed, 0, 0));
               
                }
        }
        else
        {
            if (script.change == false)
            {
                if (liftstatus == true)
                {
                    rb.useGravity = false;
                    liftstatus = false;
                    rb.AddForce(new Vector3(light_speed, 0, 0));
                   
                }
            }

        }

        this.lastVelocity = this.rb.velocity;//Rigidbody���g�p�����ړ��p

    }


    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Mirror")//���Ɠ���������
        {
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//���˃x�N�g���v�Z
            this.rb.velocity = refrectVec;
        }
        else 
        {
            rb.useGravity = true;
        }

        if (ischange == true)
        {
            if (coll.gameObject.tag == "Ground")
            {
                ischange = false;
                Destroy(targetObj);
            }
        }


    }

    public bool GetStatus()
    {
        return liftstatus;
    }

    public void SetStatus(bool status)
    {
        liftstatus = status;
    }





}
