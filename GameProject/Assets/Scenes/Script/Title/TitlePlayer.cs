using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayer : MonoBehaviour
{
    private Animator m_animator; /// �A�j���[�^�ϐ�

    public float m_playerSpeed = 0.01f;   // �v���C���[�̈ړ����x
    public float m_playerStop = 0.0f;     // �v���C���[�̎~�܂�ʒu
    public static bool m_stopFlg = false; // �v���C���[���~�܂��Ă��邩�ǂ���

    // Start is called before the first frame update
    void Start()
    {
        // �擾�������
        m_animator = GetComponent<Animator>(); // �A�j���[�^�[
    }

    // Update is called once per frame
    void Update()
    {
        // �v���C���[�̈ʒu�ۑ�
        Vector3 pos = transform.position;

        // ���̒l��菬���������� ����
        // �~�܂�t���O���I�t�̎� �i��
        if(pos.x < m_playerStop && m_stopFlg == false){
            pos.x += m_playerSpeed;            // �E�ɑ����Ă����悤��
        }

        // �v���C���[���~�܂�����
        else
        {
            pos.x = m_playerStop;  // �ʒu���Œ肷��
            m_stopFlg = true;      // �~�܂����t���O�𗧂Ă�
            m_animator.SetBool("PlayerStop", true); // �ҋ@���[�V������
        }

        // �v�Z���ʂ����Ƃɖ߂�
        transform.position = pos;
    }
}
