using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        /*
         [ �V�[���̎�� ]

         TitleScene , PlayScene , ResultScene ,         [�V�[��]
         MocStage1 , MocStage2 , MocStage3              [���b�N]
         Stage1 , Stage2 , Stage3 ,                     [�{�X�e�[�W]
         */

        //�ŏ��̃V�[�������[�h
        //SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
        SceneManager.LoadScene("MocStage1", LoadSceneMode.Single);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
