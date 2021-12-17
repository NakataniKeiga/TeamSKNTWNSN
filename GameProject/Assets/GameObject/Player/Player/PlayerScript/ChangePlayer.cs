using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public bool LightStatus = false;

    public GameObject player;
    public GameObject LightCube;

    public float LightPos_Y = 2f;

    GameObject stage;
    stage_test_script StageScript;

    // Start is called before the first frame update
    void Start()
    {
        LightCube.SetActive(false);

        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();
        

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Q)) ;
        //{
        //    if (LightCube.activeSelf)
        //    {
        //        player.SetActive(true);
        //        LightCube.SetActive(false);
        //        LightStatus = false;

        //    }

        //    else
        //    {
        //        player.SetActive(false);
        //        LightCube.SetActive(true);
        //        LightStatus = true;
        //        LightCube.transform.position = player.transform.position;

        //    }
        //}

        //Transform playerPos = player.transform;

        //Vector3 localPos = playerPos.localPosition;
        //localPos.y = +1.0f;
       


        if (StageScript.isLight_Flg == true)
        {

            if (Input.GetButtonDown("Light"))
            {
                if (LightCube.activeSelf)
                {
                    player.SetActive(true);
                    LightCube.SetActive(false);
                    LightStatus = false;
                }

                else
                {
                    player.SetActive(false);
                    LightCube.SetActive(true);
                    LightStatus = true;
                    Vector3 pos = player.transform.position;

                    pos.y += LightPos_Y;

                    player.transform.position = pos;

                    LightCube.transform.position = player.transform.position;

                }
            }

            if (LightCube.active == false)
            {
                player.SetActive(true);

            }

        }

    }
}
