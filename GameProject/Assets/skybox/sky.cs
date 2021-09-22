using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sky : MonoBehaviour
{
    public Material skybox_sunset;
    public Material skybox_daytime;

    public bool sky_flg;

    public float count;

    // Start is called before the first frame update
    void Start()
    {
        sky_flg = false;
        RenderSettings.skybox = skybox_daytime;

        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (count > 0)
        {
            count -= 1 * Time.deltaTime;
            Debug.Log("‚P‚ÂŒ¸‚ç‚µ‚½");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (sky_flg == false)
                {
                    RenderSettings.skybox = skybox_sunset;
                    sky_flg = true;
                }
                else if (sky_flg == true)
                {
                    RenderSettings.skybox = skybox_daytime;
                    sky_flg = false;
                }

                count = 3;
            }
        }
    }
}
