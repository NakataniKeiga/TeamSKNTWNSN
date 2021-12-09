using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entrance_script : MonoBehaviour
{

    public GameObject player;
    public GameObject mainCamera;
    public Vector3 worp_p_pos;
    public Vector3 worp_c_pos;
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
        if (Goal_Key_script.GetIsKey(2))
        {
            player.GetComponent<Transform>().position = worp_p_pos;
            mainCamera.GetComponent<Transform>().position = worp_c_pos;
        }
    }
}
