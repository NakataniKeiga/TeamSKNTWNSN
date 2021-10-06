using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private AudioSource bgm_;
    public float delay_ = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        bgm_ = GetComponent<AudioSource>();

        bgm_.PlayDelayed(delay_);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
