using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private AudioSource bgm_;
    // Start is called before the first frame update
    void Start()
    {
        bgm_ = GetComponent<AudioSource>();

        bgm_.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
