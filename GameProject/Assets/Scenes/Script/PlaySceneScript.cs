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
         [ シーンの種類 ]

         TitleScene , PlayScene , ResultScene ,         [シーン]
         MocStage1 , MocStage2 , MocStage3              [モック]
         Stage1 , Stage2 , Stage3 ,                     [本ステージ]
         */

        //最初のシーンをロード
        //SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
        SceneManager.LoadScene("MocStage1", LoadSceneMode.Single);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
