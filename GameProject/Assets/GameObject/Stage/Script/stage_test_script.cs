using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if(count > 0)
        {
            count -= 1 * Time.deltaTime;
            Debug.Log("ÇPÇ¬å∏ÇÁÇµÇΩ");
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                transform.Rotate(new Vector3(x, y, z));

                if(isLight_Flg)
                {
                    isLight_Flg = false;
                    Debug.Log("åªé¿èÛë‘Ç÷");
                }
                else
                {
                    isLight_Flg = true;
                    Debug.Log("ÉâÉCÉgèÛë‘Ç÷");

                }

                count = 3;
            }
        }



    }
}
