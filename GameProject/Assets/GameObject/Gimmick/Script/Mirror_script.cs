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
    public AudioClip se_Mirror;
    private AudioSource audio_source;
    public enum ROTATE_TAG
    {
        RIGHT,
        LEFT,
    }


    // Start is called before the first frame update
    void Start()
    {
        Start_Rot = transform.localEulerAngles;
        Hit_flg = false;
        Light_flg = false;
        audio_source = GetComponent<AudioSource>();
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
                if (Input.GetKey(KeyCode.UpArrow) || Input.GetButton("MirrorRot_R"))
                {
                    Debug.Log("関数を呼びます");
                    MirrorRotate(ROTATE_TAG.RIGHT);
                    if(audio_source.isPlaying==false)
                    {
                        audio_source.PlayOneShot(se_Mirror);
                    }
                }
                else if (Input.GetKey(KeyCode.DownArrow) || Input.GetButton("MirrorRot_L"))
                {
                    Debug.Log("関数を呼びます");
                    MirrorRotate(ROTATE_TAG.LEFT);
                    if (audio_source.isPlaying == false)
                    {
                        audio_source.PlayOneShot(se_Mirror);
                    }
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
        if (tag == ROTATE_TAG.RIGHT)
        {
            transform.Rotate(new Vector3(ADD_ROT_X, ADD_ROT_Y, ADD_ROT_Z));
            Debug.Log("上に向けます");
        }
        else if (tag == ROTATE_TAG.LEFT)
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
