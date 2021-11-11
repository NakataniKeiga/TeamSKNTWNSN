using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleChange : MonoBehaviour
{
    private Animator m_animator; // �A�j���[�^�[�擾
    public GameObject m_player;  // �v���C���[�̏���unity���ŃZ�b�g����p
    public Vector3 m_playerPos;  // �v���C���[�̈ʒu�ۑ��p

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();     // �A�j���[�^�[�擾�ۑ�
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_GroundPos = transform.position;    // �������g�̍��W�ۑ�
        m_playerPos = m_player.transform.position;   // �v���C���[�̈ʒu��ۑ�����

        // �����v���C���[���~�܂�����A�摜��؂�ւ���
        if (TitlePlayer.m_stopFlg){
            m_animator.SetBool("PlayerSilTitleFlg", true); // �����ŉ摜�ύX
            
           // �摜�ɓ���������̂͂����ɏ���
        }

        //transform.position = m_GroundPos;            // �w�i�̌v�Z���ʂ����Ƃɖ߂�
    }
}
