using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /// シーン切り替えに必要

public class ResultScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // エンターキーでTitleに戻る
        if(Input.GetKeyDown(KeyCode.Return))
        {
            // シーン切り替えにLoadScene関数を使う
            SceneManager.LoadScene("TitleScene");
        }
    }
}
