using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_switch : MonoBehaviour
{

    //�����ݒ�l
    const int START_OBJ_NUM = 2;
    //switch�ғ����Ԓl
    public float TIMER_MAX = 3.0f;

    //�����w��
    public GameObject[] Move_Object = new GameObject[START_OBJ_NUM];
    //�����̍��W�Ɗp�x��ۑ�
    public Vector3[] START_POS = new Vector3[START_OBJ_NUM];
    public Vector3[] START_ROT = new Vector3[START_OBJ_NUM];
    //���������W�Ɗp�x���w��
    public Vector3[] SET_ROT = new Vector3[START_OBJ_NUM];
    public Vector3[] SET_POS = new Vector3[START_OBJ_NUM];
    //Unity���ŐG��Ȃ��Ă���
    public bool[] is_REVERSE = new bool[START_OBJ_NUM];
    //���ꂼ��̌o�ߎ���
    private float[] Timer_count = new float[START_OBJ_NUM];


    // Start is called before the first frame update
    void Start()
    {
        int index = 0;
        foreach (GameObject Obj in Move_Object)
        {
            START_ROT[index] = Obj.GetComponent<Transform>().eulerAngles;
            START_POS[index] = Obj.GetComponent<Transform>().position;
            Timer_count[index] = TIMER_MAX;
            index++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int index = 0;
        foreach (GameObject Obj in Move_Object)
        {
            //���]�t���O�������Ă���Ȃ珈�����s��
            if (is_REVERSE[index] == true)
            {
              
                if(Timer_count[index] > 0)  //�^�C�}�[�J�E���g��0���傫���Ȃ珈�����s��
                {
                    //�J�E���g���}�C�i�X
                    Timer_count[index] -= 1 * Time.deltaTime;
                }
                else�@//�^�C�}�[�J�E���g��0��菬�����Ȃ珈�����s��
                {
                    //�I�u�W�F�N�g�̈ʒu�Ɗp�x���ŏ��ɕۑ��������̂ɖ߂�
                    Obj.GetComponent<Transform>().eulerAngles = START_ROT[index];
                    Obj.GetComponent<Transform>().position = START_POS[index];
                    //�^�C�}�[�J�E���g�������l�ɖ߂��ăt���O��܂�
                    Timer_count[index] = TIMER_MAX;
                    is_REVERSE[index] = false;
                }
                index++;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            int index = 0;
            foreach (GameObject Obj in Move_Object)
            {
                if (is_REVERSE[index] == false)
                {
                    Obj.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                    Obj.GetComponent<Transform>().position = Obj.GetComponent<Transform>().position + SET_POS[index];
                    is_REVERSE[index] = true;
                }
            }
            index++;
        }
        if (Input.GetButtonDown("action_joy"))
        {
            int index = 0;
            foreach (GameObject Obj in Move_Object)
            {
                if (is_REVERSE[index] == false)
                {
                    Obj.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                    Obj.GetComponent<Transform>().position = Obj.GetComponent<Transform>().position + SET_POS[index];
                    is_REVERSE[index] = true;
                }
                index++;
            }

        }
    }
}
