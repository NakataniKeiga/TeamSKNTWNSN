using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Return_Script : MonoBehaviour
{


    public GameObject Move_Switch;

    //�I�u�W�F�N�g�̏������W�ۑ��p�i��]�l���ꉞ�p�ӂ��Ă���j
    private Vector3 START_POS;
    private Vector3 START_ROT;
    //���������W�Ɗp�x���w��
    public Vector3 SET_ROT;
    public Vector3 SET_POS;

    //���]���̃t���O
    private bool REVERSE_FLG;

    private float count;


    // Start is called before the first frame update
    void Start()
    {
        START_ROT = GetComponent<Transform>().eulerAngles;
        START_POS = GetComponent<Transform>().position;
        count = 0;

        REVERSE_FLG = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count -= 1 * Time.deltaTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("stage_return"))
            {
                if (REVERSE_FLG == true)
                {
                    GetComponent<Transform>().position = START_POS;
                    GetComponent<Transform>().eulerAngles = START_ROT;
                    REVERSE_FLG = false;
                }
                else if (REVERSE_FLG == false)
                {
                    GetComponent<Transform>().position = SET_POS;
                    GetComponent<Transform>().eulerAngles = SET_ROT;

                    REVERSE_FLG = true;

                }

                //�N�[���^�C���ݒ�
                count = 3;
            }
        }

    }
}
