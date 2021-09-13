using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加したやつ↓
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
        //Mキーで「ゲーム時間一時停止」
        if(Input.GetKey(KeyCode.M))
        {
            Time.timeScale = 0;
        }

        //Nキーで「ゲーム時間再開」
        if (Input.GetKey(KeyCode.N))
        {
            Time.timeScale = 1;
        }

        //Hシーンで「タイトルシーンに遷移」
        if(Input.GetKey(KeyCode.H))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
