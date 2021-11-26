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

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーにあたった");
            if (Input.GetButtonDown("action_joy"))
            {
                switch (Door_Number)
                {
                    case 1:
                        Debug.Log("ボタンが押された");
                        SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                        break;
                    case 2:
                        Debug.Log("ボタンが押された");
                        SceneManager.LoadScene("Stage2", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                        break;
                    case 3:
                        Debug.Log("ボタンが押された");
                        SceneManager.LoadScene("Stage3", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                        break;
                    case 4:
                        Debug.Log("ボタンが押された");
                        SceneManager.LoadScene("MocStage4", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                        break;
                    case 5:
                        Debug.Log("ボタンが押された");
                        SceneManager.LoadScene("Stage5", LoadSceneMode.Single);
                        Debug.Log("Sceneを更新");
                        break;
                }
            }
        }
    }
}
