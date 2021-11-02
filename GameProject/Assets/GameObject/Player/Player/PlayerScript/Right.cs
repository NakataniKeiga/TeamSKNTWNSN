using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    private Vector3 lastVelocity;//速度ベクトル
    private Rigidbody rb;//Rigidbody用
    public float light_speed = 50;  //ライト状態の時のスピード
    public bool ischange = false;   //振り向きの状態
    public bool Lightstatus = false; //ライト状態

    GameObject player;//プレイヤー
    Player script;

    GameObject jump;//PlayerAnimeから持ってきたジャンプ
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
                Debug.Log("シフトおした");
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
        this.lastVelocity = this.rb.velocity;//Rigidbodyを使用した移動用

    }


    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Mirror")//鏡と当たった時
        {
            if (rb.useGravity == false)
            {
                Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
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
