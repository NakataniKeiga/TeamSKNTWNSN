using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    /// 1つだけ存在する実態
    public static StageManager m_instance
    {
        // ほかのクラスからm_instanceを書き換えられないようにする
        get; private set;
    }

    /// 枠がどこにいるかを保存する変数(最初はPlayにいる)
    public string m_select = "Play";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// 実態が生成された直後に1回だけ呼ばれる【Awake関数】
    private void Awake()
    {
        /// 2つ以上生成させない
        if(m_instance != null){

            /// すでに生成されていたら、2つめを消して終わる
            Destroy(gameObject);
            return;
        }

        /// インスタンスを設定
        m_instance = this;

        /// シーンを切り替えても消えないようにする
        DontDestroyOnLoad(gameObject);
    }


    /// 削除関数(生成を作ったのなら必ず用意すること!!)
    public static void DeleteInstance()
    {
        /// 削除して、nullを入れる
        Destroy(m_instance.gameObject);
        m_instance = null;
    }
}
