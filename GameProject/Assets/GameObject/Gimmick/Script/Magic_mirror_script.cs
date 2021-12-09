using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_mirror_script : MonoBehaviour
{
    //‹¾‘¤‚ÌƒIƒuƒWƒFƒNƒg
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
        //”½“]ó‘Ô‚È‚çƒgƒŠƒK[•t‚¯‚Ä“§‚¯‚é‚æ‚¤‚É‚·‚é
        if (StageScript.isLight_Flg)
        {
            GetComponent<Collider>().isTrigger = true;
        }
        else if (StageScript.isLight_Flg == false)//’Êíó‘Ô‚È‚ç‰Ÿ‚µ•Ô‚·
        {
            GetComponent<Collider>().isTrigger = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        is_Galss = true;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    //”½“]ó‘Ô‚ÅƒKƒ‰ƒX‚ÉG‚ê‚½Mirror‚Ì“–‚½‚è”»’è‚ğÁ‚·
    //    Obj.GetComponent<Collider>().isTrigger = true;
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    //”½“]ó‘Ô‚ÅƒKƒ‰ƒX‚ÉG‚ê‚½Mirror‚Ì“–‚½‚è”»’è‚ğÁ‚·
    //    Obj.GetComponent<Collider>().isTrigger = true;
    //}
    //private void OnTriggerExit(Collider other)
    //{
    //    Obj.GetComponent<Collider>().isTrigger = false;
    //}
}
