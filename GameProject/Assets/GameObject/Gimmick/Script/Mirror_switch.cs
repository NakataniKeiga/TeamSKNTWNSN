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


    GameObject stage;
    stage_test_script script;


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

            index++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        stage = GameObject.Find("stageReturn");
        script = stage.GetComponent<stage_test_script>();
    }

    private void OnTriggerStay(Collider other)
    {

        //if (Input.GetKeyDown(KeyCode.Q))
        //{
        //    int index = 0;
        //    foreach (GameObject mirror in Move_mirror)
        //    {
        //        if (is_RETURN[index] == false)
        //        {
        //            mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
        //            mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];
        //        }
        //        else if(is_RETURN[index] == true)
        //        {
        //            if(is_REVERSE[index] == false)
        //            {
        //                mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
        //                mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];
        //                is_REVERSE[index] = true;
        //            }
        //            else if (is_RETURN[index] == true)
        //            {
        //                mirror.GetComponent<Transform>().eulerAngles = START_ROT[index];
        //                mirror.GetComponent<Transform>().position = START_POS[index];

        //                 is_REVERSE[index] = false;
        //            }
        //        }
        //        index++;
        //    }
        //}
        if (Input.GetButtonDown("action_joy")|| Input.GetKeyDown(KeyCode.Q))
        {
            int index = 0;
            foreach (GameObject mirror in Move_mirror)
            {
                
                if (is_RETURN[index] == false) // 反復しないでSETした値をボタンを推すたびに加算し続ける処理
                {
                    mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                    mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];
                }
                else if (is_RETURN[index] == true)　// 反復をしてSETした値を加算した次のボタンの操作で元の座標、角度に戻す処理
                {
                    if (is_REVERSE[index] == false)
                    {
                        //メモ
                        //反転しても親子関係の設定があるため、鏡の座標自体は変わってないから　鏡の角度を反転してるかどうかを確認して調整するだけでよいかも？
                      

                        if(script.isLight_Flg == true)
                        {
                            //mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x * -1, SET_ROT[index].y, SET_ROT[index].z);
                            //mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];


                            //Vector3 return_minus = mirror.GetComponent<Transform>().position;
                            //return_minus.x *= -1;
                            //mirror.GetComponent<Transform>().position = return_minus;
                            
                        }
                        else if(script.isLight_Flg == false)
                        {
                            //mirror.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                            //mirror.GetComponent<Transform>().position = mirror.GetComponent<Transform>().position + SET_POS[index];
                            
                        }

                      is_REVERSE[index] = true;
                    }
                    else if (is_REVERSE[index] == true)
                    {
                        mirror.GetComponent<Transform>().eulerAngles = START_ROT[index];
                        mirror.GetComponent<Transform>().position = START_POS[index];

                        is_REVERSE[index] = false;
                    }
                }
                index++;
            }

        }
    }
}
