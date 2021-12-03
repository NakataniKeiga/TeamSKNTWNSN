using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpScript : MonoBehaviour
{

    public GameObject next_port;
    private Vector3 next_pos;

    public AudioClip se_warp;         // ワープのSE
    private AudioSource audio_source; // AudioSource


    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>(); // ゲットする
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

                audio_source.PlayOneShot(se_warp); // ワープの音鳴らす
            }
        }
    }

}
