using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Move : MonoBehaviour
{
    private GameObject GrassUI;

    void Start()
    {
        GrassUI = GameObject.Find("Glass (1)").transform.Find("Glass_Canvas").gameObject;

        GrassUI.gameObject.SetActive(false);
    }

    void Update()
    {
       
    }
    public void DisMove_Floor_Move()
    {

    }

    public void Grass_Move()
    {
        GrassUI.gameObject.SetActive(true);
    }

    public void Magic_Mirror_Move()
    {

    }

    public void Mirror_Move()
    {

    }

    public void Move_Floor_Move()
    {

    }

    public void Worp_Move()
    {

    }
}
