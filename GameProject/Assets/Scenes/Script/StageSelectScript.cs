using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageSelectScript : MonoBehaviour
{

    public int Door_Number = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("プレイヤーにあたった");
            switch (Door_Number)
            {
                case 1:
                    Debug.Log("ボタンが押された");
                    SceneManager.LoadScene("PlayStage1", LoadSceneMode.Single);
                    Debug.Log("Sceneを更新");
                    break;
                case 2:
                    Debug.Log("ボタンが押された");
                    SceneManager.LoadScene("PlayStage2", LoadSceneMode.Single);
                    Debug.Log("Sceneを更新");
                    break;
                case 3:
                    Debug.Log("ボタンが押された");
                    SceneManager.LoadScene("PlayStage3", LoadSceneMode.Single);
                    Debug.Log("Sceneを更新");
                    break;
                case 4:
                    Debug.Log("ボタンが押された");
                    SceneManager.LoadScene("PlayStage4", LoadSceneMode.Single);
                    Debug.Log("Sceneを更新");
                    break;
                case 5:
                    Debug.Log("ボタンが押された");
                    SceneManager.LoadScene("PlayStage5", LoadSceneMode.Single);
                    Debug.Log("Sceneを更新");
                    break;
            }
      
    }
    //private void OnTriggerStay(Collider collision)
    //{
    //    Debug.Log("プレイヤーにあたった");
    //    if (Input.GetButtonDown("action_joy"))
    //    {
    //        switch (Door_Number)
    //        {
    //            case 1:
    //                Debug.Log("ボタンが押された");
    //                SceneManager.LoadScene("PlayStage1", LoadSceneMode.Single);
    //                Debug.Log("Sceneを更新");
    //                break;
    //            case 2:
    //                Debug.Log("ボタンが押された");
    //                SceneManager.LoadScene("PlayStage2", LoadSceneMode.Single);
    //                Debug.Log("Sceneを更新");
    //                break;
    //            case 3:
    //                Debug.Log("ボタンが押された");
    //                SceneManager.LoadScene("PlayStage3", LoadSceneMode.Single);
    //                Debug.Log("Sceneを更新");
    //                break;
    //            case 4:
    //                Debug.Log("ボタンが押された");
    //                SceneManager.LoadScene("PlayStage4", LoadSceneMode.Single);
    //                Debug.Log("Sceneを更新");
    //                break;
    //            case 5:
    //                Debug.Log("ボタンが押された");
    //                SceneManager.LoadScene("PlayStage5", LoadSceneMode.Single);
    //                Debug.Log("Sceneを更新");
    //                break;
    //        }
    //    }
    //}

}
