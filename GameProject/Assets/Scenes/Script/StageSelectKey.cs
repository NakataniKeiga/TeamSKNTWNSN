using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelectKey : MonoBehaviour
{
    private const int STAGE_KEY_NUM = 4;
    static public bool[] is_Key = new bool[4];

    public GameObject lattice;
    public GameObject[] Door = new GameObject[STAGE_KEY_NUM];

    // Start is called before the first frame update
    void Start()
    {
        for(int index = 0;index< STAGE_KEY_NUM; index++)
        {
            is_Key[index] = false;
        }
        is_Key[0] = true;
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
    }
}
