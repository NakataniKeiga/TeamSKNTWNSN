using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_script : MonoBehaviour
{

    private Vector3 Start_Rot;
    private bool Hit_flg;
    private bool Light_flg;
    public float ADD_ROT_X = 0.00f;
    public float ADD_ROT_Y = 0.02f;
    public float ADD_ROT_Z = 0.00f;
    GameObject stage;
    stage_test_script script;
    public enum ROTATE_TAG
    {
        UP,
        DOWN,
    }


    // Start is called before the first frame update
    void Start()
    {
        Start_Rot = transform.localEulerAngles;
        Hit_flg = false;
        Light_flg = false;
    }

    // Update is called once per frame
    void Update()
    {
        stage = GameObject.Find("stageReturn");
        script = stage.GetComponent<stage_test_script>();
        Light_flg = script.isLight_Flg;
        if (Hit_flg == true)
        {
            if (!Light_flg)
            {
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    Debug.Log("関数を呼びます");
                    MirrorRotate(ROTATE_TAG.UP);
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    Debug.Log("関数を呼びます");
                    MirrorRotate(ROTATE_TAG.DOWN);
                }
                else if (Input.GetKey(KeyCode.R))
                {
                    Debug.Log("関数を呼びます");
                    transform.localEulerAngles = Start_Rot;
                }
            }
        }

    }

    void MirrorRotate(ROTATE_TAG tag)
    {
        if (tag == ROTATE_TAG.UP)
        {
            transform.Rotate(new Vector3(ADD_ROT_X, ADD_ROT_Y, ADD_ROT_Z));
            Debug.Log("上に向けます");
        }
        else if (tag == ROTATE_TAG.DOWN)
        {
            transform.Rotate(new Vector3((-1 * ADD_ROT_X), (-1 * ADD_ROT_Y), (-1 * ADD_ROT_Z)));
            Debug.Log("下に向けます");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーがあたりました。");
            Hit_flg = true;

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーが離れました。");
            Hit_flg = false;
        }
    }
}
