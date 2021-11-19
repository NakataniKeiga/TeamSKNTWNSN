using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class StageSelectScript : MonoBehaviour
{

    public int Stage_Number = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("action_joy"))
        {
            Debug.Log("�{�^���������ꂽ");
            SceneManager.LoadScene("MocStage4", LoadSceneMode.Single);
            Debug.Log("Scene���X�V");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("�v���C���[�ɂ�������");
            if (Input.GetButtonDown("action_joy"))
            {
                Debug.Log("�{�^���������ꂽ");
                SceneManager.LoadScene("MocStage4", LoadSceneMode.Single);
                Debug.Log("Scene���X�V");
            }
        }
    }
}
