using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /// �V�[���؂�ւ��ɕK�v

public class TitleScene : MonoBehaviour
{
    /// �g�����ǂ��ɂ��邩�̕ۑ��p�ϐ�(�ŏ���Play��1)
    public int SelectFrame = 1;

    // Start is called before the first frame update
    void Start()
    {
        /// �g�����Z�b�g����(�ŏ���Play�ɂ��Ăق���)
        StageManager.m_instance.m_select = "Play";
    }

    // Update is called once per frame
    void Update()
    {
        /// �����Řg�̈ړ��͈͂����߂Ă���---------------------
        /// �y�����E�������ꂽ �܂��� ���X�e�B�b�N���E�ɓ|���ꂽ�z ���y2�ȉ��z�̎�
        if (Input.GetKeyDown(KeyCode.RightArrow) || 0 < Input.GetAxisRaw("joystick_L_H")){

            /// �ԍ��𑫂�
            SelectFrame++;

            /// ����3�ȏ�ɂȂ�����A�߂�
            if(SelectFrame >= 3){
                SelectFrame = 2;
            }
        }

        /// �y�������������ꂽ �܂��� �E�X�e�B�b�N�����ɓ|���ꂽ�z���y1�ȏ�z�̎�
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || 0 > Input.GetAxisRaw("joystick_L_H")){

            /// �����ԍ�������
            SelectFrame--;

            /// ����0�ȉ��ɂȂ�����A�߂�
            if(SelectFrame <= 0){
                SelectFrame = 1;
            }
        }


        /// �����Ŕԍ������āA�g�̍s��������߂�-----------------
        /// Play�ɂ���Ȃ�
        if(SelectFrame == 1){

            /// �g���v���C�Ɉړ�(���͉��Ń��b�N�X�e�[�W)
            StageManager.m_instance.m_select = "StageSelect";
        }

        /// �I�v�V�����ɂ���Ȃ�
        if(SelectFrame == 2){

            /// �g���I�v�V�����Ɉړ�(�I�v�V�����o�����疼�O������ɍ��킹��B���͉���Option)
            StageManager.m_instance.m_select = "Option";
        }

        /// �ړ����鏀��(���G���^�[�����ꂽ��ړ�)
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("action_joy"))
        {

            /// �V�[���ړ�
            SceneManager.LoadScene("StageSelect");
        }

        //// �G���^�[�L�[��Play�V�[����(���͉���)
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    // �V�[���؂�ւ���LoadScene�֐����g��
        //    SceneManager.LoadScene("MocStage4");
        //}
    }
}
