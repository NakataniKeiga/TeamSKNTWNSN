using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpScript : MonoBehaviour
{

    public GameObject next_port;
    private Vector3 next_pos;

    public AudioClip se_warp;         // ワープのSE
    private AudioSource audio_source; // AudioSource

    private bool is_Input = false;
    private bool is_warp = false;

    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>(); // ゲットする
        next_pos = next_port.GetComponent<Transform>().position;

    }

    // Update is called once per frame
    void Update()
    {
        // InputUpdate();
        next_pos = next_port.GetComponent<Transform>().position;
    }

    void InputUpdate()
    {
        if (is_Input == true)
        {
            Debug.Log("プレイヤーにあたった");
            if (Input.GetButtonDown("action_joy"))
            {
                Debug.Log("ボタンが押された");
                is_warp = true;
                Debug.Log("座標更新");

                audio_source.PlayOneShot(se_warp); // ワープの音鳴らすis_Input = false;
                is_Input = false;
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("ボタンが押された");
                is_warp = true;
                Debug.Log("座標更新");

                audio_source.PlayOneShot(se_warp); // ワープの音鳴らす
                is_Input = false;

            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //if (!is_Input)
            //{
            //    is_Input = true;
            //}

            //if (is_warp == true)
            //{
            //    other.gameObject.GetComponent<Transform>().position = next_pos;
            //    is_warp = false;
            //}


            Debug.Log("プレイヤーにあたった");
            if (Input.GetButtonDown("action_joy"))
            {
                Debug.Log("ボタンが押された");
                other.gameObject.GetComponent<Transform>().position = next_pos;
                Debug.Log("座標更新");

                audio_source.PlayOneShot(se_warp); // ワープの音鳴らす
            }
            else if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Debug.Log("ボタンが押された");
                other.gameObject.GetComponent<Transform>().position = next_pos;
                Debug.Log("座標更新");

                audio_source.PlayOneShot(se_warp); // ワープの音鳴らす
            }
        }
    }

}
