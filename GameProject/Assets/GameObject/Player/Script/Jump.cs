using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rd;

    private bool Grounded = true;
    public float Jumppower = 10;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Grounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Grounded = false;
                rd.AddForce(Vector3.up * Jumppower);
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Grounded = true;
            Debug.Log("“–‚½‚Á‚½");
        }
    }
}
