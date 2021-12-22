using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Volume_Slider : MonoBehaviour
{
    public Slider VolumeSlider;
    AudioSource audioSource;

    int maxValue;
    int nowValue;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        VolumeSlider.onValueChanged.AddListener(value => this.audioSource.volume = value);

        VolumeSlider = GetComponent<Slider>();

        maxValue = 100;
        nowValue = GetComponent<FreeCamera>().GetMoveSpeed();


        //�X���C�_�[�̍ő�l�̐ݒ�
        VolumeSlider.maxValue = maxValue;

        //�X���C�_�[�̌��ݒl�̐ݒ�
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
