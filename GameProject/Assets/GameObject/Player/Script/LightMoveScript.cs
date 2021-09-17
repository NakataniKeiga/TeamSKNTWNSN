using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMoveScript : MonoBehaviour
{
    private Vector3 lastVelocity;   //速度ベクトル
    private Rigidbody rb;           //Rigidbody用
    public float light_speed = 50;
    public bool ischange = false;   //
    public bool liftStatus = false; //
    public bool jumpBan = false;    //ジャンプ禁止用　フラグ

    GameObject player;
    Player script;
    Jump jumpScript;

    GameObject stage;
    stage_test_script StageScript;


    Vector3 PlayerPos;

    public GameObject targetObj;

    void Start()
    {

        player = GameObject.Find("moc_player");
        script = player.GetComponent<Player>();
        jumpScript = player.GetComponent<Jump>();

        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();


        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (StageScript.isLight_Flg == true && jumpScript.Grounded == true)
        {
            if (ischange == false)
            {

                if (Input.GetKeyDown(KeyCode.LeftShift))
                {

                    Debug.Log("シフトおした");
                    liftStatus = true;
                    ischange = true;
                    jumpBan = true;

                }
            }

        }

    }

    void FixedUpdate()
    {
        if (script.change == true)
        {
            if (liftStatus == true)
            {
                rb.useGravity = false;
                liftStatus = false;
                rb.AddForce(new Vector3(-light_speed, 0, 0));
            }
        }
        else
        {
            if (script.change == false)
            {
                if (liftStatus == true)
                {
                    rb.useGravity = false;
                    liftStatus = false;
                    rb.AddForce(new Vector3(light_speed, 0, 0));
                }
            }

        }

        this.lastVelocity = this.rb.velocity;//Rigidbodyを使用した移動用

    }


    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Mirror")//鏡と当たった時
        {
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
            this.rb.velocity = refrectVec;
        }
        else
        {
            rb.useGravity = true;
            jumpBan = false;

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
        return liftStatus;
    }

    public void SetStatus(bool status)
    {
        liftStatus = status;
    }





}
