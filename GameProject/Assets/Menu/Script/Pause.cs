using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ǉ��������
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private GameObject MiniMap;
    private GameObject Menu2D;
    private GameObject Option2D;

    public Sprite _on;
    public Sprite _off;
    public Image image;

    private enum ButtonType
    {
        on,
        off
    }

    private ButtonType buttontype;

    // Start is called before the first frame update
    void Start()
    {
        Menu2D = GameObject.Find("Menu").transform.Find("Menu_Canvas").gameObject;
        Option2D = GameObject.Find("Menu").transform.Find("Option_Canvas").gameObject;

        //UI���\����
        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //��
        if (Input.GetKey(KeyCode.M))
        {
            OpenMenu_Move();
        }
    }

    public void OpenMenu_Move()
    {
        Time.timeScale = 0;

        Menu2D = GameObject.Find("Menu").transform.Find("Menu_Canvas").gameObject;
        Option2D = GameObject.Find("Menu").transform.Find("Option_Canvas").gameObject;

        Menu2D.gameObject.SetActive(true);
        Option2D.gameObject.SetActive(false);
    }

    public void PlayBack_Move()
    {
        Time.timeScale = 1;

        Menu2D = GameObject.Find("Menu").transform.Find("Menu_Canvas").gameObject;
        Option2D = GameObject.Find("Menu").transform.Find("Option_Canvas").gameObject;

        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
    }

    public void OpenOption_Move()
    {
        Menu2D = GameObject.Find("Menu").transform.Find("Menu_Canvas").gameObject;
        Option2D = GameObject.Find("Menu").transform.Find("Option_Canvas").gameObject;

        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(true);
    }

    public void StageReset_Move()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void TitleBack_Move()
    {
        SceneManager.LoadScene("TitleScene");
        Time.timeScale = 1;
    }

    public void MiniMap_Move()
    {
        MiniMap = GameObject.Find("Menu").transform.Find("Map").gameObject;

        switch (buttontype)
        {
            case ButtonType.on:
                {
                    image.sprite = _off;
                    MiniMap.gameObject.SetActive(false);
                    buttontype = ButtonType.off;
                }
                break;
                    
            case ButtonType.off:
                {
                    image.sprite = _on;
                    MiniMap.gameObject.SetActive(true);
                    buttontype = ButtonType.on;
                }
                break;
        }

    }

    public void MenuBack_Move()
    {
        Menu2D = GameObject.Find("Menu").transform.Find("Menu_Canvas").gameObject;
        Option2D = GameObject.Find("Menu").transform.Find("Option_Canvas").gameObject;

        Menu2D.gameObject.SetActive(true);
        Option2D.gameObject.SetActive(false);
    }

    public void InitOption_Move()
    {
        //�~�j�}�b�v������
        image.sprite = _on;
        MiniMap = GameObject.Find("Menu").transform.Find("Map").gameObject;
        MiniMap.gameObject.SetActive(true);

        //�{�����[��������

    }

    public void QuitApp()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
#endif
    }
}

