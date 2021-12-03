using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBack : MonoBehaviour
{
    private GameObject Menu2D;
    private GameObject Option2D;
    private GameObject MenuBack2D;

    // Start is called before the first frame update
    void Start()
    {
        Menu2D = GameObject.Find("Menu_Canvas");
        Option2D = GameObject.Find("Option_Canvas");
        MenuBack2D = GameObject.Find("Menu_BackCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBack_Move()
    {
        Time.timeScale = 1;

        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(false);
        MenuBack2D.gameObject.SetActive(false);
    }
}
