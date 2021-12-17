using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Volume_Slider : MonoBehaviour
{
    Slider VolumeSlider;
    int maxValue;
    int nowValue;

    // Use this for initialization
    void Start()
    {
        VolumeSlider = GetComponent<Slider>();

        maxValue = 100;
        nowValue = GetComponent<FreeCamera>().GetMoveSpeed();


        //スライダーの最大値の設定
        VolumeSlider.maxValue = maxValue;

        //スライダーの現在値の設定
        VolumeSlider.value = nowValue;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FreeCam_Move()
    {
    }
}
