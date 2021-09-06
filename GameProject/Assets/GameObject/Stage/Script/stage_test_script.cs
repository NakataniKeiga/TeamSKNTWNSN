using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stage_test_script : MonoBehaviour
{
    public int x;
    public int y;
    public int z;



    // Start is called before the first frame update
    void Start()
    {
        x = 0; y = 180; z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            transform.Rotate(new Vector3(x, y, z));
        }

    }
}
