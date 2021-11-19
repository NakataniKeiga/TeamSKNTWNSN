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

    // Start is called before the first frame update
    void Start()
    {
        MiniMap = GameObject.Find("MiniMap_Canvas");
        Menu2D = GameObject.Find("Menu_testCanvas");
        Option2D = GameObject.Find("Option_testCanvas");

        //UIを非表示に
        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Mキーで「ゲーム時間一時停止」
        if (Input.GetKey(KeyCode.M))
        {
            Time.timeScale = 0;

            //メニュー画面表示
            Menu2D.gameObject.SetActive(true);
            //Option2D.gameObject.SetActive(true);
        }

        //Nキーで「ゲーム時間再開」
        if (Input.GetKey(KeyCode.N))
        {
            Time.timeScale = 1;

            //メニュー画面削除
            Menu2D.gameObject.SetActive(false);
            Option2D.gameObject.SetActive(false);
        }

        //Hキーで「タイトルシーンに遷移」
        if (Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene("TitleScene");
        }

        //Rキーで「ステージリセット」
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        //Kキーで「ミニマップを表示→非表示」
        if (Input.GetKey(KeyCode.K))
        {
            MiniMap.gameObject.SetActive(false);
        }

        //Lキーで「ミニマップ非表示→表示」
        if (Input.GetKey(KeyCode.L))
        {
            MiniMap.gameObject.SetActive(true);
        }

        //Escキーで「ゲーム終了」--------------------------
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

