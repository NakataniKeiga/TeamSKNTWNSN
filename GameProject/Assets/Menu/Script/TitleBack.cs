using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加したやつ↓
using UnityEngine.SceneManagement;

public class TitleBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void TitleBack_Move()
    {
        SceneManager.LoadScene("TitleScene");
        Time.timeScale = 1;
    }
}
