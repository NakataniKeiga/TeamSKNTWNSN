using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warpScript : MonoBehaviour
{

    public GameObject next_port;
    private Vector3 next_pos;

    public AudioClip se_warp;         // ���[�v��SE
    private AudioSource audio_source; // AudioSource


    // Start is called before the first frame update
    void Start()
    {
        audio_source = GetComponent<AudioSource>(); // �Q�b�g����
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("�v���C���[�ɂ�������");
            if (Input.GetButtonDown("action_joy"))
            {
                Debug.Log("�{�^���������ꂽ");
                next_pos = next_port.GetComponent<Transform>().position;
                other.gameObject.GetComponent<Transform>().position = next_pos;
                Debug.Log("���W�X�V");

                audio_source.PlayOneShot(se_warp); // ���[�v�̉��炷
            }
        }
    }

}
