using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /// �V�[���؂�ւ��ɕK�v

public class ResultPlayerScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ���͉���0���������烊�U���h�ɍs���悤�ɂ���
        // ����ύX����Ƃ���
        if(Input.GetKeyDown(KeyCode.P))
        {
            // ���U���h�V�[���ɐ؂�ւ�
            SceneManager.LoadScene("ResultScene");
        }
    }
}
