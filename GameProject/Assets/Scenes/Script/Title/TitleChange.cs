using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleChange : MonoBehaviour
{
    private Animator m_animator; // アニメーター取得
    public GameObject m_player;  // プレイヤーの情報をunity側でセットする用
    public Vector3 m_playerPos;  // プレイヤーの位置保存用

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();     // アニメーター取得保存
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m_GroundPos = transform.position;    // 自分自身の座標保存
        m_playerPos = m_player.transform.position;   // プレイヤーの位置を保存する

        // もしプレイヤーが止まったら、画像を切り替える
        if (TitlePlayer.m_stopFlg){
            m_animator.SetBool("PlayerSilTitleFlg", true); // ここで画像変更
            
           // 画像に動き加えるのはここに書く
        }

        //transform.position = m_GroundPos;            // 背景の計算結果をもとに戻す
    }
}
