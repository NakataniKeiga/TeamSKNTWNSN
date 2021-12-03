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
        // エスケープキーまたはコントローラー押したら
        if(Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("action_joy"))
        {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        
        #else
            // ゲームを終わらせる
            Application.Quit();
        #endif  
        }
    }
}
