using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �V�[���Ǘ��ɕK�v

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /// �m�F�̂��߂̕�
        Debug.Log("���̃X�e�[�W��" + StageManager.m_instance.m_select + "�ł�");

        /// �I�����ꂽ�X�e�[�W�ɍs������(�g�̈ʒu��ۑ�)
        string m_select = StageManager.m_instance.m_select;

        /// �I�΂ꂽ�X�e�[�W�����[�h����
        /// �yPlay�V�[��(�X�N���v�g�����Ȃ��V�[��)�z+ �y�������̃V�[���z�Ƃ����C���[�W(�����Ɏ��s�ł���)
        SceneManager.LoadScene(m_select, LoadSceneMode.Additive);

        /// �����g��Ȃ��̂Ȃ�A�폜��K���Ă�!!
        StageManager.DeleteInstance();
    }

    // Update is called once per frame
    void Update()
    {
        /// ���U���h�ɍs���ꍇ��if���͂����ɏ���
    }
}
