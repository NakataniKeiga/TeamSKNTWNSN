using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_switch : MonoBehaviour
{
    //初代
    public GameObject move_mirror_1;
    public const int MOVE_MIRROR_MAX = 4;
    public float SET_ROT_X_1 = 0.00f;
    public float SET_ROT_Y_1 = 0.00f;
    public float SET_ROT_Z_1 = 0.00f;
    //二代目
    //鏡を指定
    public GameObject[] Move_mirror = new GameObject[4];
    //初期の座標と角度を保存
    public Vector3[] START_POS = new Vector3[MOVE_MIRROR_MAX];
    public Vector3[] START_ROT = new Vector3[MOVE_MIRROR_MAX];
    //動かす座標と角度を指定
    public Vector3[] SET_ROT = new Vector3[MOVE_MIRROR_MAX];
    public Vector3[] SET_POS = new Vector3[MOVE_MIRROR_MAX];
    //反復にするかどうか
    public bool[] is_RETURN = new bool[MOVE_MIRROR_MAX];
    //Unity側で触らなくていい
    public bool[] is_REVERSE = new bool[4];

    public Vector3[] RETURN_ROT = new Vector3[MOVE_MIRROR_MAX];
    public Vector3[] RETURN_POS = new Vector3[MOVE_MIRROR_MAX];

    private bool is_Input = false;

    GameObject stage;
    stage_test_script script;

    //switchアニメーション
    Animator anim;
    bool anim_flg = false;


    // Start is called before the first frame update
    void Start()
    {
        int index = 0;
        foreach (GameObject mirror in Move_mirror)
        {
            START_ROT[index] = mirror.GetComponent<Transform>().eulerAngles;
            START_POS[index] = mirror.GetComponent<Transform>().position;

            RETURN_ROT[index] = mirror.GetComponent<Transform>().eulerAngles;
            RETURN_POS[index] = mirror.GetComponent<Transform>().position;

            is_REVERSE[index] = false;

            index++;

          
        }
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        stage = GameObject.Find("stageReturn");
        script = stage.GetComponent<stage_test_script>();
        InputUpdeta();

        if(anim_flg == true)
        {
            //アニメーション
            anim.SetBool("LeverUp", true);
        }
        else if(anim_flg == false)
        {
            //アニメーション
            anim.SetBool("LeverUp", false);
        }

    }

    void InputUpdeta()
    {
        if (is_Input == true)
        {
            if (Input.GetButtonDown("action_joy"))
            {
                Debug.Log("ボタンを押している");
                int index = 0;
                foreach (GameObject mirror in Move_mirror)
                {

                    if (is_RETURN[index] == false) // 反復しないでSETした値をボタンを推すたびに加算し続ける処理
                    {
                        mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                        mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];
                        is_Input = false;
                    }
                    else if (is_RETURN[index] == true) // 反復をしてSETした値を加算した次のボタンの操作で元の座標、角度に戻す処理
                    {
                        if (is_REVERSE[index] == false)
                        {                           
                            if (script.isLight_Flg == true)//反転している状態
                            {
                                mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x * -1, SET_ROT[index].y, SET_ROT[index].z);
                                mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];

                            }
                            else if (script.isLight_Flg == false)//反転していない状態
                            {
                                mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                                mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];

                            }
                        
                            is_REVERSE[index] = true;
                            is_Input = false;

                            anim_flg = true;
                        }
                        else if (is_REVERSE[index] == true)
                        {
                            if (script.isLight_Flg == true)//反転している状態
                            {
                                mirror.GetComponent<Transform>().eulerAngles = START_ROT[index];
                                Vector3 pos = START_POS[index];
                                pos.x *= -1;
                                mirror.GetComponent<Transform>().position = pos;
                            }
                            else if (script.isLight_Flg == false)//反転していない状態
                            {
                                mirror.GetComponent<Transform>().eulerAngles = START_ROT[index];
                                mirror.GetComponent<Transform>().position = START_POS[index];
                            }

                            is_REVERSE[index] = false;
                            is_Input = false;

                            anim_flg = false;
                        }
                    }
                    index++;
                }

            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("プレイヤーが当たっている");
        if (!is_Input)
        {
            is_Input = true;
        }
    }
}
