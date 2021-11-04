using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasswall : MonoBehaviour
{
    GameObject playerobject;
    Player playermove;

    GameObject stage;
    stage_test_script StageScript;

    GameObject glasswall;

    int player_layer;
    int glasswall_layer;

    // Start is called before the first frame update
    void Start()
    {
        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();

        playerobject = GameObject.Find("player");
        playermove = playerobject.GetComponent<Player>();
        glasswall = GameObject.Find("GlassWall");
        player_layer = LayerMask.NameToLayer("player_layer");
        glasswall_layer = LayerMask.NameToLayer("glasswall_layer");
    }

    // Update is called once per frame
    void Update()
    {
        if (StageScript.isLight_Flg)
        {
            //Debug.Log("ÉKÉâÉXè¡Ç∑");
            Physics.IgnoreLayerCollision(player_layer, glasswall_layer);
        }
        else if (StageScript.isLight_Flg == false)
        {
            //Debug.Log("ÉKÉâÉXÇ¬ÇØÇÈ");
            Physics.IgnoreLayerCollision(player_layer, glasswall_layer, false);
        }
    }
}
