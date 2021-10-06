using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /// シーン切り替えに必要

public class ResultPlayerScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 今は仮で0をおしたらリザルドに行くようにする
        // 今後変更するところ
        if(Input.GetKeyDown(KeyCode.P))
        {
            // リザルドシーンに切り替え
            SceneManager.LoadScene("ResultScene");
        }
    }
}
