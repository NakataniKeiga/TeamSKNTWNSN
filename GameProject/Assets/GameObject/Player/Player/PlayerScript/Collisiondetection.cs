using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiondetection : MonoBehaviour
{

    public GameObject Player;
    public GameObject Light;
    public GameObject Coll;

    public bool UpCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll)
    {
        UpCollision = false;
        if (coll.gameObject.tag == "Ground")
        {
            UpCollision = true;
            Player.transform.position = Coll.transform.position;
            Light.SetActive(false);

            Debug.Log("“–‚½‚Á‚½");
        }
        else
        {

           
            

        }
    }
}
