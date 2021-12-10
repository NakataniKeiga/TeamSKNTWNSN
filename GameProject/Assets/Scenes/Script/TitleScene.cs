using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; /// シーン切り替えに必要

public class TitleScene : MonoBehaviour
{
    /// 枠が今どこにいるかの保存用変数(最初はPlayの1)
    public int SelectFrame = 1;

    // Start is called before the first frame update
    void Start()
    {
        /// 枠をリセットする(最初はPlayにいてほしい)
        StageManager.m_instance.m_select = "Play";
    }

    // Update is called once per frame
    void Update()
    {
        /// ここで枠の移動範囲を決めている---------------------
        /// 【もし右が押された または 左スティックが右に倒された】 かつ【2以下】の時
        if (Input.GetKeyDown(KeyCode.RightArrow) || 0 < Input.GetAxisRaw("joystick_L_H")){

            /// 番号を足す
            SelectFrame++;

            /// もし3以上になったら、戻す
            if(SelectFrame >= 3){
                SelectFrame = 2;
            }
        }

        /// 【もし左が押された または 右スティックが左に倒された】かつ【1以上】の時
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || 0 > Input.GetAxisRaw("joystick_L_H")){

            /// 部屋番号を引く
            SelectFrame--;

            /// もし0以下になったら、戻す
            if(SelectFrame <= 0){
                SelectFrame = 1;
            }
        }


        /// ここで番号を見て、枠の行き先を決める-----------------
        /// Playにあるなら
        if(SelectFrame == 1){

            /// 枠をプレイに移動(今は仮でモックステージ)
            StageManager.m_instance.m_select = "StageSelect";
        }

        /// オプションにあるなら
        if(SelectFrame == 2){

            /// 枠をオプションに移動(オプション出来たら名前をそれに合わせる。今は仮のOption)
            StageManager.m_instance.m_select = "Option";
        }

        /// 移動する準備(仮エンター押されたら移動)
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("action_joy"))
        {

            /// シーン移動
            SceneManager.LoadScene("StageSelect");
        }

        //// エンターキーでPlayシーンへ(今は仮で)
        //if (Input.GetKeyDown(KeyCode.Return))
        //{
        //    // シーン切り替えにLoadScene関数を使う
        //    SceneManager.LoadScene("MocStage4");
        //}
    }
}
