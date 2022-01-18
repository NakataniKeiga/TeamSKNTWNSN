using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    // アニメーター取得
    private Animator m_animator;

    // Start is called before the first frame update
    void Start()
    {
        // ゲットする
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /// もし枠がゲームスタートにあるなら(今は仮でモック。あとから変える)
        if(StageManager.m_instance.m_select == "StageSelect")
        {
            m_animator.SetBool("ShineFlg", true);  // ゲームスタートボタンは光らせる
        }

        /// もし枠がオプションにあるなら(あとから変える)
        else if(StageManager.m_instance.m_select != "StageSelect")
        {
            m_animator.SetBool("ShineFlg", false); // ゲームスタートボタンは光らないように
        }
    }
}
