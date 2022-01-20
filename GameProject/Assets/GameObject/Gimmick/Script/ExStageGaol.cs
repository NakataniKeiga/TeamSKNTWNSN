using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExStageGaol : MonoBehaviour
{

    public int ExKeyNumber;

    GameObject stage;
    stage_test_script StageScript;
    

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(StageScript.isLight_Flg == false)
        {
            switch (ExKeyNumber)
            {
                case 0:
                    {
                        SceneManager.LoadScene("ResultScene", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }break;
                case 1:
                    {
                        SceneManager.LoadScene("E_1F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 2:
                    {
                        SceneManager.LoadScene("E_2F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 3:
                    {
                        SceneManager.LoadScene("E_3F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 4:
                    {
                        SceneManager.LoadScene("E_4F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 5:
                    {
                        SceneManager.LoadScene("E_5F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 6:
                    {
                        SceneManager.LoadScene("E_6F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 7:
                    {
                        SceneManager.LoadScene("E_7F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 8:
                    {
                        SceneManager.LoadScene("E_8F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 9:
                    {
                        SceneManager.LoadScene("E_9F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 10:
                    {
                        SceneManager.LoadScene("E_10F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 11:
                    {
                        SceneManager.LoadScene("E_11F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 12:
                    {
                        SceneManager.LoadScene("E_12F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 13:
                    {
                        SceneManager.LoadScene("E_13F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 14:
                    {
                        SceneManager.LoadScene("E_14F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;
                case 15:
                    {
                        SceneManager.LoadScene("E_15F", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                    }
                    break;

            }
        }
    }
}
