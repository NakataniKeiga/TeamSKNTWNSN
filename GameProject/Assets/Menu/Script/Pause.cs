using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加したやつ↓
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

        //UIを非表示に
        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
        MenuBack2D.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OpenMenu_Move()
    {
        Time.timeScale = 0;

        //メニュー画面表示
        Menu2D.gameObject.SetActive(true);
        MenuBack2D.gameObject.SetActive(true);
    }

    public void PlayBack_Move()
    {
        Time.timeScale = 1;

        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
        MenuBack2D.gameObject.SetActive(false);
    }

    public void OpenOption_Move()
    {
        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(true);
        MiniMap.gameObject.SetActive(false);
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

    }

    public void MenuBack_Move()
    {
        Menu2D.gameObject.SetActive(true);
        Option2D.gameObject.SetActive(false);
    }

    public void InitOption_Move()
    {

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

