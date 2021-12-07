using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_switch : MonoBehaviour
{

    //初期設定値
    const int START_OBJ_NUM = 2;
    //switch稼働時間値
    public float TIMER_MAX = 3.0f;

    //鏡を指定
    public GameObject[] Move_Object = new GameObject[START_OBJ_NUM];
    //初期の座標と角度を保存
    public Vector3[] START_POS = new Vector3[START_OBJ_NUM];
    public Vector3[] START_ROT = new Vector3[START_OBJ_NUM];
    //動かす座標と角度を指定
    public Vector3[] SET_ROT = new Vector3[START_OBJ_NUM];
    public Vector3[] SET_POS = new Vector3[START_OBJ_NUM];
    //Unity側で触らなくていい
    public bool[] is_REVERSE = new bool[START_OBJ_NUM];
    //それぞれの経過時間
    private float[] Timer_count = new float[START_OBJ_NUM];


    // Start is called before the first frame update
    void Start()
    {
        int index = 0;
        foreach (GameObject Obj in Move_Object)
        {
            START_ROT[index] = Obj.GetComponent<Transform>().eulerAngles;
            START_POS[index] = Obj.GetComponent<Transform>().position;
            Timer_count[index] = TIMER_MAX;
            index++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int index = 0;
        foreach (GameObject Obj in Move_Object)
        {
            //反転フラグがたっているなら処理を行う
            if (is_REVERSE[index] == true)
            {
              
                if(Timer_count[index] > 0)  //タイマーカウントが0より大きいなら処理を行う
                {
                    //カウントをマイナス
                    Timer_count[index] -= 1 * Time.deltaTime;
                }
                else　//タイマーカウントが0より小さいなら処理を行う
                {
                    //オブジェクトの位置と角度を最初に保存したものに戻す
                    Obj.GetComponent<Transform>().eulerAngles = START_ROT[index];
                    Obj.GetComponent<Transform>().position = START_POS[index];
                    //タイマーカウントを初期値に戻してフラグを折る
                    Timer_count[index] = TIMER_MAX;
                    is_REVERSE[index] = false;
                }
                index++;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {
            int index = 0;
            foreach (GameObject Obj in Move_Object)
            {
                if (is_REVERSE[index] == false)
                {
                    Obj.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                    Obj.GetComponent<Transform>().position = Obj.GetComponent<Transform>().position + SET_POS[index];
                    is_REVERSE[index] = true;
                }
            }
            index++;
        }
        if (Input.GetButtonDown("action_joy"))
        {
            int index = 0;
            foreach (GameObject Obj in Move_Object)
            {
                if (is_REVERSE[index] == false)
                {
                    Obj.GetComponent<Transform>().Rotate(SET_ROT[index].x, SET_ROT[index].y, SET_ROT[index].z);
                    Obj.GetComponent<Transform>().position = Obj.GetComponent<Transform>().position + SET_POS[index];
                    is_REVERSE[index] = true;
                }
                index++;
            }

        }
    }
}
