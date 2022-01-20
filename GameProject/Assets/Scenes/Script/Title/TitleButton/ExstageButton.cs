using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExstageButton : MonoBehaviour
{
    // �A�j���[�^�擾
    private Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        // �Q�b�g����
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /// �����g���Q�[���X�^�[�g�ɂ���Ȃ�(���͉��Ń��b�N�B���Ƃ���ς���)
        if (StageManager.m_instance.ExFlg == false)
        {
            m_animator.SetBool("Exflg", false);  // �G�N�X�g���{�^���͌���Ȃ�
        }

        /// �����g���I�v�V�����ɂ���Ȃ�(���Ƃ���ς���)
        else if (StageManager.m_instance.ExFlg == true)
        {
            m_animator.SetBool("Exflg", true);   // �G�N�X�g���{�^���͌���
        }
    }
}
