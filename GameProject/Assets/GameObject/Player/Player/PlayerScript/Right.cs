using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    private Vector3 lastVelocity;//���x�x�N�g��
    private Rigidbody rb;//Rigidbody�p
    public float light_speed = 50;  //���C�g��Ԃ̎��̃X�s�[�h
    public bool ischange = false;   //�U������̏��
    public bool Lightstatus = false; //���C�g���

    GameObject player;//�v���C���[
    Player script;

    GameObject jump;//PlayerAnime���玝���Ă����W�����v
    PlayerAnime jumpscript;

    GameObject stage;
    stage_test_script StageScript;

    GameObject direction;
    PlayerAction directionScript;

    Vector3 PlayerPos;

    public GameObject targetObj;

    void Start()
    {

        player = GameObject.Find("player");
        script = player.GetComponent<Player>();

        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();

        jump = GameObject.Find("player");
        jumpscript = jump.GetComponent<PlayerAnime>();

        direction = GameObject.Find("player");
        directionScript = direction.GetComponent<PlayerAction>();

        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (StageScript.isLight_Flg == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Debug.Log("�V�t�g������");
                Lightstatus = true;
                ischange = true;
         
            }
            else
            {
              
            }
        }



    }

    void FixedUpdate()
    {

        if (Lightstatus == true)
        {
            if (directionScript.change == true)
            {
                rb.useGravity = false;
                Lightstatus = false;
                rb.AddForce(new Vector3(-light_speed, 0, 0));
            }
            else if (directionScript.change == false)
            {
                rb.useGravity = false;
                Lightstatus = false;
                rb.AddForce(new Vector3(light_speed, 0, 0));

            }


        }
        this.lastVelocity = this.rb.velocity;//Rigidbody���g�p�����ړ��p

    }


    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Mirror")//���Ɠ���������
        {
            if (rb.useGravity == false)
            {
                Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//���˃x�N�g���v�Z
                this.rb.velocity = refrectVec;
            }
        }
        else
        {
            rb.useGravity = true;
        }


        if (coll.gameObject.tag == "Ground")
        {
            ischange = false;
            Destroy(targetObj);
        }



    }

}
