using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic_mirror_script : MonoBehaviour
{
    //�����̃I�u�W�F�N�g
    public GameObject Obj;

    public bool is_Mirror = false;
    public bool is_Galss = false;

    // Start is called before the first frame update
    void Start()
    {
        //Obj.GetComponent<Collider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (is_Mirror == true)//true�Ȃ狾
        {

        }
        else if (is_Galss == true)//false�Ȃ�K���X
        {
            Obj.GetComponent<Collider>().enabled = false;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (is_Mirror == true)//true�Ȃ狾
        {

        }
        else if (is_Galss == true)//false�Ȃ�K���X
        {
            Obj.GetComponent<Collider>().enabled = true;
        }
    }
}
