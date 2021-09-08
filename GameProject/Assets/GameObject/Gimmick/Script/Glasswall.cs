using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glasswall : MonoBehaviour
{
    GameObject playerobject;
    Player playermove;
    GameObject glasswall;
    int player_layer;
    int glasswall_layer;

    // Start is called before the first frame update
    void Start()
    {
        playerobject = GameObject.Find("moc_player");
        playermove = playerobject.GetComponent<Player>();
        glasswall = GameObject.Find("GlassWall");
        player_layer = LayerMask.NameToLayer("player_layer");
        glasswall_layer = LayerMask.NameToLayer("glasswall_layer");
    }

    // Update is called once per frame
    void Update()
    {
        //if (playermove.light)
        //{
        //    Physics.IgnoreLayerCollision(player_layer, glasswall_layer);
        //}
        //else if (playermove.light == false)
        //{
        //    Physics.IgnoreLayerCollision(player_layer, glasswall_layer, false);
        //}
    }
}
