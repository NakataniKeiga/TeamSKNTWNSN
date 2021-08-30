using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_block : MonoBehaviour
{

    public float amplitudeX = 4.0f;
    public float amplitudeY = 4.0f;
    public float amplitudeZ = 4.0f;
    public float amplitudeSpeed = 2.0f;

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        // ゲーム開始時の位置
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = new Vector3((Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeX + startPosition.x), (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeY + startPosition.y), (Mathf.Sin((Time.time) * amplitudeSpeed) * amplitudeZ + startPosition.z));
    }
}
