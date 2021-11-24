using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//í«â¡ÇµÇΩÇ‚Ç¬Å´
using UnityEngine.UI;

public class Change_Image : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite _on;
    public Sprite _off;
    private bool flg = true;

    public void changeImage()
    {
        var img = GetComponent<Image>();
        img.sprite = (flg) ? _on : _off;
        flg = !flg;
    }
}
