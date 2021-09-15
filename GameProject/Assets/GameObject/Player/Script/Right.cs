using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    private Vector3 lastVelocity;//���x�x�N�g��
    private Rigidbody rb;//Rigidbody�p
    public float light_speed = 50;
    private bool isSpace=false;

    GameObject player;

    Player script;

    Vector3 PlayerPos;

    public GameObject targetObj;

    void Start()
    {
        player = GameObject.Find("moc_player");
        script = player.GetComponent<Player>();


      rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

      

        if (Input.GetKey(KeyCode.Space))
        {
            isSpace = true;
        }
        
    }

    void FixedUpdate()
    {
        if (script.change == true)
        {
                if (isSpace==true)
                {
                    rb.useGravity = false;
                    isSpace = false;
                    rb.AddForce(new Vector3(-light_speed, 0, 0));
                    isSpace = false;
                }
        }
        else
        {
            if (script.change == false)
            {
                if (isSpace==true)
                {
                    rb.useGravity = false;
                    isSpace = false;
                    rb.AddForce(new Vector3(light_speed, 0, 0));
                    isSpace = false;
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
        if (coll.gameObject.tag == "Ground")
        {
            Destroy(targetObj);
        }


    }

    
       
   

}
