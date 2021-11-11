using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlayer : MonoBehaviour
{
    private Animator m_animator; /// アニメータ変数

    public float m_playerSpeed = 0.01f;   // プレイヤーの移動速度
    public float m_playerStop = 0.0f;     // プレイヤーの止まる位置
    public static bool m_stopFlg = false; // プレイヤーが止まっているかどうか

    // Start is called before the first frame update
    void Start()
    {
        // 取得するもの
        m_animator = GetComponent<Animator>(); // アニメーター
    }

    // Update is called once per frame
    void Update()
    {
        // プレイヤーの位置保存
        Vector3 pos = transform.position;

        // この値より小さい時だけ かつ
        // 止まるフラグがオフの時 進む
        if(pos.x < m_playerStop && m_stopFlg == false){
            pos.x += m_playerSpeed;            // 右に走っていくように
        }

        // プレイヤーが止まったら
        else
        {
            pos.x = m_playerStop;  // 位置を固定する
            m_stopFlg = true;      // 止まったフラグを立てる
            m_animator.SetBool("PlayerStop", true); // 待機モーションへ
        }

        // 計算結果をもとに戻す
        transform.position = pos;
    }
}
