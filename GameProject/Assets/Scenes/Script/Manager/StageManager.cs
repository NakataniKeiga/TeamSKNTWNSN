using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    /// 1�������݂������
    public static StageManager m_instance
    {
        // �ق��̃N���X����m_instance�������������Ȃ��悤�ɂ���
        get; private set;
    }

    /// �g���ǂ��ɂ��邩��ۑ�����ϐ�(�ŏ���Play�ɂ���)
    public string m_select = "Play";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// ���Ԃ��������ꂽ�����1�񂾂��Ă΂��yAwake�֐��z
    private void Awake()
    {
        /// 2�ȏ㐶�������Ȃ�
        if(m_instance != null){

            /// ���łɐ�������Ă�����A2�߂������ďI���
            Destroy(gameObject);
            return;
        }

        /// �C���X�^���X��ݒ�
        m_instance = this;

        /// �V�[����؂�ւ��Ă������Ȃ��悤�ɂ���
        DontDestroyOnLoad(gameObject);
    }


    /// �폜�֐�(������������̂Ȃ�K���p�ӂ��邱��!!)
    public static void DeleteInstance()
    {
        /// �폜���āAnull������
        Destroy(m_instance.gameObject);
        m_instance = null;
    }
}
