using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class FreeCam_Slider : MonoBehaviour
{
    Slider freecamSlider;
    int maxSpeed;
    int nowSpeed;

    // Use this for initialization
    void Start()
    {
        freecamSlider = GetComponent<Slider>();

        maxSpeed = 3;
        nowSpeed = 1;


        //�X���C�_�[�̍ő�l�̐ݒ�
        freecamSlider.maxValue = maxSpeed;

        //�X���C�_�[�̌��ݒl�̐ݒ�
        freecamSlider.value = nowSpeed;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FreeCam_Move()
    {
        GetComponent<FreeCamera>().SetMoveSpeed(nowSpeed);
    }
}
