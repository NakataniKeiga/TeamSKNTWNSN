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
        // �G���^�[�L�[��Title�ɖ߂�
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // �V�[���؂�ւ���LoadScene�֐����g��
            SceneManager.LoadScene("TitleScene");
        }
    }
}
