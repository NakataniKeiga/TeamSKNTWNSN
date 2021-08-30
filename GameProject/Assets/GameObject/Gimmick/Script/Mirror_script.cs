using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror_script : MonoBehaviour
{

    private Vector3 Rot;
    public float ADD_ROT = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rot.y += ADD_ROT;
        transform.Rotate(new Vector3(ADD_ROT, 0, 0));
    }
}
