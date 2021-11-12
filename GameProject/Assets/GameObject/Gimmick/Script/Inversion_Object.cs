using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inversion_Object : MonoBehaviour
{

    //反転に使う数値
    private int Reverse_namber = -1;

    //反転する物を入れる空のオブジェクト用
    GameObject Reverse_object;

    //反転するオブジェクトの座標保存用
    private Vector3 save_Coordinate;
    private float save_x, save_y, save_z;


    // Start is called before the first frame update
    void Start()
    {
        Reverse_object = GameObject.Find("reverse_obj");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetButtonDown("stage_return"))
        {
            //座標を持ってくる
            save_Coordinate = this.transform.position;

            save_x = save_Coordinate.x;

            //マイナスを掛けて「＋/-」を切り替えて反転させる。
            //空のオブジェクトは基本的に座標「0,0,0」
            save_x = save_x * Reverse_namber;

            save_Coordinate.x = save_x;

            this.transform.position = save_Coordinate;


        }
    }
}
