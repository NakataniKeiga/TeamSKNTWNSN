using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class SE_Slider : MonoBehaviour
{
    Slider SeSlider;
    int maxValue;
    int nowValue;

    // Use this for initialization
    void Start()
    {
        SeSlider = GetComponent<Slider>();

        maxValue = 100;
        nowValue = GetComponent<FreeCamera>().GetMoveSpeed();


        //�X���C�_�[�̍ő�l�̐ݒ�
        SeSlider.maxValue = maxValue ;

        //�X���C�_�[�̌��ݒl�̐ݒ�
        SeSlider.value = nowValue;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FreeCam_Move()
    {
    }
}
