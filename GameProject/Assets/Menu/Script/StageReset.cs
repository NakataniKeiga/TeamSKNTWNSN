using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加したやつ↓
using UnityEngine.SceneManagement;

public class StageReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void StageReset_Move()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
