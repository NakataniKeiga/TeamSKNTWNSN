using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name, UnloadSceneOptions.None);

            if(SceneManager.GetActiveScene().name == "MocStage1")
            {
                SceneManager.LoadScene("MocStage2",LoadSceneMode.Single);
                Debug.Log("ステージ２へ");
            }
            else if(SceneManager.GetActiveScene().name == "MocStage2")
            {
                SceneManager.LoadScene("MocStage3", LoadSceneMode.Single);
                Debug.Log("ステージ3へ");
            }
            else if(SceneManager.GetActiveScene().name == "MocStage3")
            {
                SceneManager.LoadScene("ClearScene",LoadSceneMode.Single);
                Debug.Log("Clearへ");
            }
        }
    }
}
