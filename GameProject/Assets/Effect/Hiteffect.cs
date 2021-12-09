using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hiteffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //　出現させるエフェクト
    [SerializeField]
    private GameObject effectObject;
    //　エフェクトを消す秒数
    [SerializeField]
    private float deleteTime;
    //　エフェクトの出現位置のオフセット値
    [SerializeField]
    private float offset_X;
    //　エフェクトの出現位置のオフセット値
    [SerializeField]
    private float offset_Y;

    private ParticleSystem particle;

    /// <summary>
    /// 衝突した時
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // 当たった相手が"Player"タグを持っていたら
        if (collision.gameObject.tag == "Player")
        {
            //　ゲームオブジェクト登場時にエフェクトをインスタンス化
            var instantiateEffect = GameObject.Instantiate(effectObject, transform.position + new Vector3(offset_X, offset_Y, 0f), Quaternion.identity) as GameObject;
            Destroy(instantiateEffect, deleteTime);
        }
    }
}
