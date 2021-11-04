using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_switch : MonoBehaviour
{

    public GameObject move_mirror;
    public float SET_ROT_X = 0.00f;
    public float SET_ROT_Y = 0.00f;
    public float SET_ROT_Z = 0.00f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        //if (move_mirror.GetComponent<Mirror_script>().GetHitFlg())
        //{
        //    if (!move_mirror.GetComponent<Mirror_script>().GetLightFlg())
        //    {
        //        if (Input.GetKey(KeyCode.UpArrow) || Input.GetButton("MirrorRot_R"))
        //        {
        //            Debug.Log("ä÷êîÇåƒÇ—Ç‹Ç∑");
        //            move_mirror.GetComponent<Mirror_script>().
        //                MirrorRotate(move_mirror.GetComponent<Mirror_script>().GetRotTag(0));
        //        }
        //        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetButton("MirrorRot_L"))
        //        {
        //            Debug.Log("ä÷êîÇåƒÇ—Ç‹Ç∑");
        //            move_mirror.GetComponent<Mirror_script>().
        //                MirrorRotate(move_mirror.GetComponent<Mirror_script>().GetRotTag(1));

        //        }
        //    }
        //}
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            move_mirror.GetComponent<Transform>().Rotate(SET_ROT_X, SET_ROT_Y, SET_ROT_Z);
        }
        if (Input.GetButtonDown("action_joy"))
        {
            move_mirror.GetComponent<Transform>().Rotate(SET_ROT_X, SET_ROT_Y, SET_ROT_Z);

        }
    }
}
