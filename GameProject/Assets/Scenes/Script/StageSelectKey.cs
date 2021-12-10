using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectKey : MonoBehaviour
{
    private const int STAGE_KEY_NUM = 4;
    private float UP_MAX = 10.0f;
    private const float UP_SPD = 0.01f;
    public bool[] is_Key = new bool[4];
    public AudioClip barred_se;
    private AudioSource audio_source;

    public GameObject lattice;
    private Vector3 move_pos;
    public GameObject[] Door = new GameObject[STAGE_KEY_NUM];

    // Start is called before the first frame update
    void Start()
    {
        for(int index = 0;index< STAGE_KEY_NUM; index++)
        {
            is_Key[index] = Goal_Key_script.GetIsKey(index);
        }
        is_Key[0] = true;
        if (is_Key[1] == true || is_Key[2] == true)
        {
            is_Key[0] = false;
        }

        audio_source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        int index = 0;
        foreach(GameObject door in Door)
        {
            if (is_Key[index] == true)
            {
                door.GetComponent<Collider>().isTrigger = true;
            }
            else if (is_Key[index] == false)
            {
                door.GetComponent<Collider>().isTrigger = false;
            }
            index++;
        }

        if (is_Key[2] == true)
        {
            move_pos = lattice.GetComponent<Transform>().position;

            if (UP_MAX > 0)
            {
                if (audio_source.isPlaying == false)
                {
                    audio_source.PlayOneShot(barred_se);
                }

                move_pos.y += UP_SPD;
                lattice.GetComponent<Transform>().position = move_pos;
                UP_MAX -= UP_SPD;
            }
        }
    }
}
