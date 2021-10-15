using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // シーン管理に必要

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /// 確認のための文
        Debug.Log("今のステージは" + StageManager.m_instance.m_select + "です");

        /// 選択されたステージに行く準備(枠の位置を保存)
        string m_select = StageManager.m_instance.m_select;

        /// 選ばれたステージをロードする
        /// 【Playシーン(スクリプトしかないシーン)】+ 【第一引数のシーン】というイメージ(同時に実行できる)
        SceneManager.LoadScene(m_select, LoadSceneMode.Additive);

        /// もう使わないのなら、削除を必ず呼ぶ!!
        StageManager.DeleteInstance();
    }

    // Update is called once per frame
    void Update()
    {
        /// リザルドに行く場合のif文はここに書く
    }
}
