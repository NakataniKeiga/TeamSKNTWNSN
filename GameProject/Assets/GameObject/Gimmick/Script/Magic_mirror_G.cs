
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_mirror_G : MonoBehaviour
{
    //鏡側のオブジェクト
    public GameObject Obj;

    GameObject stage;
    stage_test_script StageScript;

    public bool is_Galss = false;

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();
    }

    // Update is called once per frame
    void Update()
    {
        //反転状態ならトリガー付けて透けるようにする
        if (StageScript.isLight_Flg)
        {
            GetComponent<Collider>().isTrigger = true;
        }
        else if (StageScript.isLight_Flg == false)//通常状態なら押し返す
        {
            GetComponent<Collider>().isTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("当たった");
        //反転状態でガラスに触れた時Mirrorの当たり判定を消す
        Obj.GetComponent<Collider>().isTrigger = true;
    }
    private void OnTriggerStay(Collider other)
    {
        //反転状態でガラスに触れた時Mirrorの当たり判定を消す
        Debug.Log("当たっている");
        Obj.GetComponent<Collider>().isTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Obj.GetComponent<Collider>().isTrigger = false;
    }
}
