using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inversion_Object : MonoBehaviour
{

    //���]�Ɏg�����l
    private int Reverse_namber = -1;

    //���]���镨�������̃I�u�W�F�N�g�p
    GameObject Reverse_object;

    //���]����I�u�W�F�N�g�̍��W�ۑ��p
    private Vector3 save_Coordinate;
    private float save_x, save_y, save_z;


    // Start is called before the first frame update
    void Start()
    {
        Reverse_object = GameObject.Find("reverse_obj");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("stage_return"))
        {
            //���W�������Ă���
            save_Coordinate = this.transform.position;

            save_x = save_Coordinate.x;

            //�}�C�i�X���|���āu�{/-�v��؂�ւ��Ĕ��]������B
            //��̃I�u�W�F�N�g�͊�{�I�ɍ��W�u0,0,0�v
            save_x = save_x * Reverse_namber;

            save_Coordinate.x = save_x;

            this.transform.position = save_Coordinate;


        }
    }
}
