using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
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
        if (StageManager.m_instance.m_select == "MocStage4")
        {
            m_animator.SetBool("ShineFlg", false);  // �I�v�V�����{�^���͌���Ȃ�
        }

        /// �����g���I�v�V�����ɂ���Ȃ�(���Ƃ���ς���)
        else if (StageManager.m_instance.m_select == "Option")
        {
            m_animator.SetBool("ShineFlg", true); // �I�v�V�����{�^���͌���
        }
    }
}