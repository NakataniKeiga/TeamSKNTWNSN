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
        // �G�X�P�[�v�L�[�܂��̓R���g���[���[��������
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("action_joy"))
        {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        
        #else
            // �Q�[�����I��点��
            Application.Quit();
        #endif  
        }
    }
}
