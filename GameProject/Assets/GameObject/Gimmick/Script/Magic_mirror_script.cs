using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_mirror_script : MonoBehaviour
{
    //�����̃I�u�W�F�N�g
    public GameObject Obj;

    GameObject stage;
    stage_test_script StageScript;

    public bool is_Galss = false;

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();
    }

    // Update is called once per frame
    void Update()
    {
        //���]��ԂȂ�g���K�[�t���ē�����悤�ɂ���
        if (StageScript.isLight_Flg)
        {
            GetComponent<Collider>().isTrigger = true;
        }
        else if (StageScript.isLight_Flg == false)//�ʏ��ԂȂ牟���Ԃ�
        {
            GetComponent<Collider>().isTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        is_Galss = true;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    //���]��ԂŃK���X�ɐG�ꂽ��Mirror�̓����蔻�������
    //    Obj.GetComponent<Collider>().isTrigger = true;
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    //���]��ԂŃK���X�ɐG�ꂽ��Mirror�̓����蔻�������
    //    Obj.GetComponent<Collider>().isTrigger = true;
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    Obj.GetComponent<Collider>().isTrigger = false;
    //}
}
