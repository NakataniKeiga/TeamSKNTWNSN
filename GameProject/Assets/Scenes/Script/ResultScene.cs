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
        // ゲーム終了させるための準備
        // (今は仮)エンターキーが押されたら終わる
        if(Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("action_joy"))
        {

        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
        #else
                    // ゲームを終了させる
                    Application.Quit();
        #endif
        }
    }
}
