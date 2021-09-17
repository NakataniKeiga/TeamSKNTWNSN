using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rd;

    private bool Grounded = true;
    public float Jumppower = 300;

    GameObject light_;
    LightMoveScript lightScript;

    // Start is called before the first frame update
    void Start()
    {
        //-----------------------------------------------
        //����moc�Ȃ̂ŃI�u�W�F�N�g����moc_player�ɂȂ��Ă��܂�
        //�{��������Ƃ���{ Find("�{��������Ƃ���Player�̃I�u�W�F�N�g��") } �ɂ��܂��傤�B

        light_ = GameObject.Find("moc_player");
        //------------------------------------------------
        lightScript = light_.GetComponent<LightMoveScript>();

        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Grounded == true)
        {
            if(lightScript.liftStatus == false)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Grounded = false;
                    rd.AddForce(Vector3.up * Jumppower);
                }
            }

        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Grounded = true;
            Debug.Log("��������");
        }
    }
}
