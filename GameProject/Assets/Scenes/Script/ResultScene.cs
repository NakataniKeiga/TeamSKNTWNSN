using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /// �V�[���؂�ւ��ɕK�v

public class ResultScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �Q�[���I�������邽�߂̏���
        // (���͉�)�G���^�[�L�[�������ꂽ��I���
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("action_joy"))
        {

        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
        #else
                    // �Q�[�����I��������
                    Application.Quit();
        #endif
        }
    }
}
