using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal_Script : MonoBehaviour
{
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && StageScript.isLight_Flg == false)
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name, UnloadSceneOptions.None);

            if(SceneManager.GetActiveScene().name == "MocStage1")
            {
                SceneManager.LoadScene("MocStage2",LoadSceneMode.Single);
                Debug.Log("ステージ２へ");
            }
            else if(SceneManager.GetActiveScene().name == "MocStage2")
            {
                //SceneManager.LoadScene("MocStage3", LoadSceneMode.Single);
                //Debug.Log("ステージ3へ");

                SceneManager.LoadScene("MocStage1", LoadSceneMode.Single);
                Debug.Log("ステージ1へ");

            }
            //else if(SceneManager.GetActiveScene().name == "MocStage3")
            //{
            //    //SceneManager.LoadScene("ClearScene",LoadSceneMode.Single);
            //    SceneManager.LoadScene("MocStage1", LoadSceneMode.Single);

            //    Debug.Log("Clearへ");
            //}
            else if (SceneManager.GetActiveScene().name == "MocStage4")
            {
                Debug.Log("Clearへ");
                SceneManager.LoadScene("ResultScene", LoadSceneMode.Single);
            }
        }
    }
}
