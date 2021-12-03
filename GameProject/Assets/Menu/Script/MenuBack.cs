using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBack : MonoBehaviour
{
    private GameObject Menu2D;
    private GameObject Option2D;

    // Start is called before the first frame update
    void Start()
    {
        Menu2D = GameObject.Find("Menu_Canvas");
        Option2D = GameObject.Find("Option_Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuBack_Move()
    {
        Menu2D.gameObject.SetActive(true);
        Option2D.gameObject.SetActive(false);
    }
}
