using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameButton : MonoBehaviour
{
    /// 1��̓��͂ŁA�g�������ړ���
    public float FrameWidth = 6.0f;

    /// UI�𓮂����̂ɕK�v�ɂȂ�yRecttranceform�z
    private RectTransform recttrancfrofm;

    // Start is called before the first frame update
    void Start()
    {
        /// �l�������邽�߁AGet����
        recttrancfrofm = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        /// ���̘g�̈ʒu���擾����
        Vector3 Pos = recttrancfrofm.anchoredPosition3D;

        /// �yPlay�z�̎��̘g�̈ʒu
        if(StageManager.m_instance.m_select == "StageSelect")
        {
            Pos.x = -6.0f;
        }

        /// �y�G�N�X�g���z�̎��̘g�̈ʒu
        else if (StageManager.m_instance.ExFlg == true)
        {
            Pos.x = 0.0f;
        }

        /// �y�I�v�V�����z�̎��̘g�̈ʒu
        else if(StageManager.m_instance.m_select == "Option"){
            Pos.x = 6.0f;
        }

        /// �v�Z���ʂ����Ƃɖ߂��A�ʒu�𔽉f������
        recttrancfrofm.anchoredPosition3D = Pos;
    }
}
