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
            Debug.Log("�v���C���[�ɂ�������");
            if (Input.GetButtonDown("action_joy"))
            {
                switch (Door_Number)
                {
                    case 1:
                        Debug.Log("�{�^���������ꂽ");
                        SceneManager.LoadScene("Stage1", LoadSceneMode.Single);
                        Debug.Log("Scene���X�V");
                        break;
                    case 2:
                        Debug.Log("�{�^���������ꂽ");
                        SceneManager.LoadScene("Stage2", LoadSceneMode.Single);
                        Debug.Log("Scene���X�V");
                        break;
                    case 3:
                        Debug.Log("�{�^���������ꂽ");
                        SceneManager.LoadScene("Stage3", LoadSceneMode.Single);
                        Debug.Log("Scene���X�V");
                        break;
                    case 4:
                        Debug.Log("�{�^���������ꂽ");
                        SceneManager.LoadScene("MocStage4", LoadSceneMode.Single);
                        Debug.Log("Scene���X�V");
                        break;
                    case 5:
                        Debug.Log("�{�^���������ꂽ");
                        SceneManager.LoadScene("Stage5", LoadSceneMode.Single);
                        Debug.Log("Scene���X�V");
                        break;
                }
            }
        }
    }
}
