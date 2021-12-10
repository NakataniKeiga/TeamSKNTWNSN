using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal_Key_script : MonoBehaviour
{

    public int Key_Number;

    GameObject stage;
    stage_test_script StageScript;
    public static bool[] is_Key = new bool[4];
    private const int STAGE_KEY_NUM = 4;

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();
        for (int index = 0; index < STAGE_KEY_NUM; index++)
        {
            is_Key[index] = false;
        }
        is_Key[0] = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static bool GetIsKey(int num)
    {
        return is_Key[num];
    }

    public static void SetIsKey(int num, bool flg)
    {
        is_Key[num] = flg;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (StageScript.isLight_Flg == false)//通常状態なら押し返す
        {
            if (Key_Number != 4)
            {
                SetIsKey(Key_Number, true);
                SetIsKey(Key_Number - 1, false);
                SceneManager.LoadScene("StageSelect", LoadSceneMode.Single);
                Debug.Log("Sceneを更新");
            }
            else if(Key_Number == 4)
            {
                SceneManager.LoadScene("ResultScene", LoadSceneMode.Single);
                Debug.Log("Sceneを更新");
            }
        }
    }
}
