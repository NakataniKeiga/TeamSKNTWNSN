using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ǉ��������
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //M�L�[�Łu�Q�[�����Ԉꎞ��~�v
        if(Input.GetKey(KeyCode.M))
        {
            Time.timeScale = 0;
        }

        //N�L�[�Łu�Q�[�����ԍĊJ�v
        if (Input.GetKey(KeyCode.N))
        {
            Time.timeScale = 1;
        }

        //H�V�[���Łu�^�C�g���V�[���ɑJ�ځv
        if(Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
