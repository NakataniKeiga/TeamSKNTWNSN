using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//í«â¡ÇµÇΩÇ‚Ç¬Å´
using UnityEngine.UI;


public class Select : MonoBehaviour
{
    Button PlayBack_Button;
    Button Option_Button;
    Button StageReset_Button;
    Button TitleBack_Button;

    // Start is called before the first frame update
    void Start()
    {
       PlayBack_Button = GameObject.Find("Menu_Canvas/PlayBack_Button").GetComponent<Button>();

        PlayBack_Button.Select();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
