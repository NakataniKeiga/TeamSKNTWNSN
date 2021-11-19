using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ǉ��������
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private GameObject MiniMap;
    private GameObject Menu2D;
    private GameObject Option2D;

    // Start is called before the first frame update
    void Start()
    {
        MiniMap = GameObject.Find("MiniMap_Canvas");
        Menu2D = GameObject.Find("Menu_testCanvas");
        Option2D = GameObject.Find("Option_testCanvas");

        //UI���\����
        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //M�L�[�Łu�Q�[�����Ԉꎞ��~�v
        if (Input.GetKey(KeyCode.M))
        {
            Time.timeScale = 0;

            //���j���[��ʕ\��
            Menu2D.gameObject.SetActive(true);
            //Option2D.gameObject.SetActive(true);
        }

        //N�L�[�Łu�Q�[�����ԍĊJ�v
        if (Input.GetKey(KeyCode.N))
        {
            Time.timeScale = 1;

            //���j���[��ʍ폜
            Menu2D.gameObject.SetActive(false);
            Option2D.gameObject.SetActive(false);
        }

        //H�L�[�Łu�^�C�g���V�[���ɑJ�ځv
        if (Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene("TitleScene");
        }

        //R�L�[�Łu�X�e�[�W���Z�b�g�v
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //K�L�[�Łu�~�j�}�b�v��\������\���v
        if (Input.GetKey(KeyCode.K))
        {
            MiniMap.gameObject.SetActive(false);
        }

        //L�L�[�Łu�~�j�}�b�v��\�����\���v
        if (Input.GetKey(KeyCode.L))
        {
            MiniMap.gameObject.SetActive(true);
        }

        //Esc�L�[�Łu�Q�[���I���v--------------------------
        if (Input.GetKey(KeyCode.Escape))
        {
            Quit();
        }

        void Quit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
            #endif
        }
        //--------------------------------------------------
    }

}

