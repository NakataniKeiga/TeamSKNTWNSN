using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiteffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�@�o��������G�t�F�N�g
    [SerializeField]
    private GameObject effectObject;
    //�@�G�t�F�N�g�������b��
    [SerializeField]
    private float deleteTime;
    //�@�G�t�F�N�g�̏o���ʒu�̃I�t�Z�b�g�l
    [SerializeField]
    private float offset_X;
    //�@�G�t�F�N�g�̏o���ʒu�̃I�t�Z�b�g�l
    [SerializeField]
    private float offset_Y;

    private ParticleSystem particle;

    /// <summary>
    /// �Փ˂�����
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // �����������肪"Player"�^�O�������Ă�����
        if (collision.gameObject.tag == "Player")
        {
            //�@�Q�[���I�u�W�F�N�g�o�ꎞ�ɃG�t�F�N�g���C���X�^���X��
            var instantiateEffect = GameObject.Instantiate(effectObject, transform.position + new Vector3(offset_X, offset_Y, 0f), Quaternion.identity) as GameObject;
            Destroy(instantiateEffect, deleteTime);
        }
    }
}
