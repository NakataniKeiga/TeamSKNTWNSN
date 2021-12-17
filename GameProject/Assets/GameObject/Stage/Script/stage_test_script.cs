using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage_test_script : MonoBehaviour
{
    public int x;
    public int y;
    public int z;

    public bool isLight_Flg;
    public float count;


    // Start is called before the first frame update
    void Start()
    {
        x = 0; y = 180; z = 0;

        count = 0;
        isLight_Flg = false;



    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "PlayStage5")
        {
            //ステージ5は常に反転状態で光になれるので　反転処理をさせない＆常に光状態
            isLight_Flg = true;
            return;
        }



        if(count > 0)
        {
            count -= 1 * Time.deltaTime;
            Debug.Log("１つ減らした");
        }
        else
        {

            if(Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("stage_return"))
            {
                transform.Rotate(new Vector3(x, y, z));

                if(isLight_Flg)
                {
                    isLight_Flg = false;
                    Debug.Log("現実状態へ");
                }
                else
                {
                    isLight_Flg = true;
                    Debug.Log("ライト状態へ");

                }

                count = 3;
            }
            

            

        }



    }
}
