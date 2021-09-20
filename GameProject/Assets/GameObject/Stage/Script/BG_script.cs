using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_script : MonoBehaviour
{

    GameObject stage;
    stage_test_script script;
    private bool Light_flg;
    private Vector3 rot;
    public float count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rot = new Vector3(0, 0, 0);
        stage = GameObject.Find("stageReturn");
        script = stage.GetComponent<stage_test_script>();
        Light_flg = script.isLight_Flg;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count -= 1 * Time.deltaTime;

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {


                if (Light_flg)
                {
                    rot.y = 180.0f;
                    transform.Rotate(rot);
                }
                else
                {
                    rot.y = -180.0f;
                    transform.Rotate(rot);
                }
                count = 3;
            }
        }
    }
}
