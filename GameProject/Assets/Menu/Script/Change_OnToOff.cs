using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//í«â¡ÇµÇΩÇ‚Ç¬Å´
using UnityEngine.UI;

public class Change_OnToOff : MonoBehaviour
{
    public enum ButtonType
    {
        on,
        off
    }

    public ButtonType buttontype;

    public Sprite _on;
    public Sprite _off;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeOnToOff_Move()
    {
       //if(ImageSwitch == true) { image.sprite = _off; ImageSwitch = false; };
       //if(ImageSwitch == false) { image.sprite = _on; ImageSwitch = true; };
    }
}
