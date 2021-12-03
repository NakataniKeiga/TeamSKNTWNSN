using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOption : MonoBehaviour
{
    private GameObject MiniMap;
    private GameObject Menu2D;
    private GameObject Option2D;

    // Start is called before the first frame update
    void Start()
    {
        MiniMap = GameObject.Find("MiniMap_Canvas");
        Menu2D = GameObject.Find("Menu_Canvas");
        Option2D = GameObject.Find("Option_Canvas");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OpenOption_Move()
    {
        Menu2D.gameObject.SetActive(false);
        Option2D.gameObject.SetActive(true);
        MiniMap.gameObject.SetActive(false);
    }
}
