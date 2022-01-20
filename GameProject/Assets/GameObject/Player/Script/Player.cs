using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //　UIの追加部分　========
    public GameObject UI_ctrl;
    //========================

    float x;
    float z;

    public bool change = true;
    private Rigidbody rigidbody_;
    private Animator animator_;
    private Vector3 PlayerPos;
    private bool isTP_1 = false;
    private bool isTP_2 = false;

    GameObject player;
    //Right script;
    LightMoveScript script;


    Vector3 movingDirecion = Vector3.zero;

    //移動速度
    public float move_speed = 100.0f;

    GameObject maincamera;

    Vector3 cameraPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("moc_player");
        //script = player.GetComponent<Right>();
        script = player.GetComponent<LightMoveScript>();


        //PlayerPos = GetComponent<Transform>().position;
        rigidbody_ = GetComponent<Rigidbody>();
        rigidbody_.constraints = RigidbodyConstraints.FreezeRotation;
        maincamera = GameObject.Find("Main Camera");


        //　UIの追加部分　==================
        UI_ctrl = GameObject.Find("UI");
        //==================================
    }

// Update is called once per frame
void Update()
    {

        if (script.ischange == false)
        {

            //// 左右キーを押した時の値（0～1）
            x = Input.GetAxis("Horizontal") * move_speed;


            if (Input.GetKey(KeyCode.RightArrow))
            {
                change = false;
            }
            if (Input.GetKey(KeyCode.D))
            {
                change = false;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                change = true;
                }
            if (Input.GetKey(KeyCode.A))
            {
                change = true;
            }



        }
      

        PlayerPos = new Vector3(x, 0, 0);


        //↑キーで歩きモーションへ

        cameraPos = this.gameObject.transform.position;
        cameraPos.y += 5f;
        cameraPos.z += -30f;
        maincamera.transform.position = cameraPos;
       

        if (PlayerPos.magnitude > 0.1)
        {
            transform.rotation = Quaternion.LookRotation(PlayerPos);
            transform.Translate(Vector3.forward * move_speed * Time.deltaTime);
        }


        if(this.transform.position.y < -10)
        {
            this.transform.position = new Vector3(this.transform.position.x, 5, this.transform.position.z);
        }

        if (isTP_1 == true)
        {
            transform.position = new Vector3(60,25, 0);
            isTP_1 = false;
        }
        if (isTP_2 == true)
        {
            transform.position = new Vector3(-92.5f,48.5f, 0);
            isTP_2 = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Debug.Log("当たった");
        }
        if (transform.parent == null && collision.gameObject.tag == "Move_Block")
        {

            var block = new GameObject();
            block.transform.parent = collision.gameObject.transform;
            transform.parent = block.transform;
        }
        if (collision.gameObject.tag == "warp1")
        {
            isTP_1 = true;
        }
        if (collision.gameObject.tag == "warp2")
        {
            isTP_2 = true;
        }

        //　UIの追加部分　================================
        if (collision.gameObject.name == "Switch_Box")
        {
            UI_ctrl.GetComponent<UI_Move>().Grass_Move();
        }
        //================================================
    }
    private void OnCollisionExit(Collision collision)
    {
        if (transform.parent != null && collision.gameObject.tag == "Move_Block")
        {
            transform.parent = null;
        }
    }
    public float GetSpeed()
    {
        return move_speed;
    }

    public void SetSpeed(float speed)
    {
        move_speed = speed;
    }
        
   
}
