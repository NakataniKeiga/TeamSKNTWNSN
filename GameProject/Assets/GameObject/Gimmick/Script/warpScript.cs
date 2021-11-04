using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpScript : MonoBehaviour
{

    public GameObject next_port;
    private Vector3 next_pos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("プレイヤーにあたった");
            if (Input.GetButtonDown("action_joy"))
            {
                Debug.Log("ボタンが押された");
                next_pos = next_port.GetComponent<Transform>().position;
                other.gameObject.GetComponent<Transform>().position = next_pos;
                Debug.Log("座標更新");
            }
        }
    }

}
