using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameButton : MonoBehaviour
{
    /// 1‰ñ‚Ì“ü—Í‚ÅA˜g‚ª“®‚­ˆÚ“®—Ê
    public float FrameWidth = 6.0f;

    /// UI‚ğ“®‚©‚·‚Ì‚É•K—v‚É‚È‚éyRecttranceformz
    private RectTransform recttrancfrofm;

    // Start is called before the first frame update
    void Start()
    {
        /// ’l‚ğ‚¢‚¶‚é‚½‚ßAGet‚·‚é
        recttrancfrofm = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        /// ¡‚Ì˜g‚ÌˆÊ’u‚ğæ“¾‚·‚é
        Vector3 Pos = recttrancfrofm.anchoredPosition3D;

        /// yPlayz‚Ì‚Ì˜g‚ÌˆÊ’u
        if(StageManager.m_instance.m_select == "MocStage4"){
            Pos.x = -3.0f;
        }

        /// yƒIƒvƒVƒ‡ƒ“z‚Ì‚Ì˜g‚ÌˆÊ’u
        else if(StageManager.m_instance.m_select == "Option"){
            Pos.x = 3.0f;
        }

        /// ŒvZŒ‹‰Ê‚ğ‚à‚Æ‚É–ß‚µAˆÊ’u‚ğ”½‰f‚³‚¹‚é
        recttrancfrofm.anchoredPosition3D = Pos;
    }
}
