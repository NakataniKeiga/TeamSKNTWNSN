using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    public bool LightStatus = false;

    public GameObject player;
    public GameObject LightCube;

    // Start is called before the first frame update
    void Start()
    {
        LightCube.SetActive(false);

        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (LightCube.activeSelf)
            {
                player.SetActive(true);
                LightCube.SetActive(false);
                LightStatus = false;

            }

            else
            {
                player.SetActive(false);
                LightCube.SetActive(true);
                LightStatus = true;
                LightCube.transform.position = player.transform.position;

            }
        }

        if (LightCube.active == false)
        {
            player.SetActive(true);
        
        }

    }
}
