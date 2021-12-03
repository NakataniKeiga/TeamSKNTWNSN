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
    private GameObject MenuBack2D;

    // Start is called before the first frame update
    void Start()
    {
        MiniMap = GameObject.Find("MiniMap_Canvas");
        Menu2D = GameObject.Find("Menu_Canvas");
        Option2D = GameObject.Find("Option_Canvas");
        MenuBack2D = GameObject.Find("Menu_BackCanvas");

        //UI���\����
        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
        MenuBack2D.gameObject.SetActive(false);
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
            MenuBack2D.gameObject.SetActive(true);
        }

        //O�L�[�Łu�I�v�V�����\���v
        if(Input.GetKey(KeyCode.O))
        {
            Time.timeScale = 0;

            Option2D.gameObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.N))
        {
            Time.timeScale = 1;

            Menu2D.gameObject.SetActive(false);
            Option2D.gameObject.SetActive(false);
            MenuBack2D.gameObject.SetActive(false);
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

