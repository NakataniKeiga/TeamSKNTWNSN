using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameButton : MonoBehaviour
{
    /// 1回の入力で、枠が動く移動量
    public float FrameWidth = 6.0f;

    /// UIを動かすのに必要になる【Recttranceform】
    private RectTransform recttrancfrofm;

    // Start is called before the first frame update
    void Start()
    {
        /// 値をいじるため、Getする
        recttrancfrofm = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        /// 今の枠の位置を取得する
        Vector3 Pos = recttrancfrofm.anchoredPosition3D;

        /// 【Play】の時の枠の位置
        if(StageManager.m_instance.m_select == "StageSelect")
        {
            Pos.x = -6.0f;
        }

        /// 【エクストラ】の時の枠の位置
        else if (StageManager.m_instance.ExFlg == true)
        {
            Pos.x = 0.0f;
        }

        /// 【オプション】の時の枠の位置
        else if(StageManager.m_instance.m_select == "Option"){
            Pos.x = 6.0f;
        }

        /// 計算結果をもとに戻し、位置を反映させる
        recttrancfrofm.anchoredPosition3D = Pos;
    }
}
