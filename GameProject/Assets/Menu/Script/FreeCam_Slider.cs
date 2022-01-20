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


        //スライダーの最大値の設定
        freecamSlider.maxValue = maxSpeed;

        //スライダーの現在値の設定
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
