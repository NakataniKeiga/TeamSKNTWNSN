using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMoveScript : MonoBehaviour
{
    private Vector3 lastVelocity;//速度ベクトル
    private Rigidbody rb;//Rigidbody用
    public float light_speed = 50;
    public bool ischange = false;
    public bool liftStatus = false;

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
            if (ischange == false)
            {

                if (Input.GetKeyDown(KeyCode.LeftShift))
                {

                    Debug.Log("シフトおした");
                    liftStatus = true;
                    ischange = true;


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
                
                rb.AddForce(new Vector3(-light_speed, 0, 0));


                liftStatus = false;
            }
        }
        else
        {
            if (script.change == false)
            {
                if (liftStatus == true)
                {
                    rb.useGravity = false;
                    
                    rb.AddForce(new Vector3(light_speed, 0, 0));

                    liftStatus = false;
                    

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
