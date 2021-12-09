using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加したやつ↓
using UnityEngine.SceneManagement;
using UnityEditor;

public class WatchTower : MonoBehaviour
{
    [SerializeField]
    private WatchTower onlyForwardSearchEnemy;
    [SerializeField]
    private SphereCollider searchArea;
    [SerializeField]
    private float searchAngle = 0f;

    public AudioClip se_WatchTower;    // 監視塔に見つかった時のSE
    private AudioSource audio_source;  // AudioSource

    private Vector3 start_pos;
    [SerializeField]
    private GameObject Player;

    GameObject stage;
    stage_test_script StageScript;

    private void Start()
    {
        // 追加したのでGetする
        audio_source = GetComponent<AudioSource>();

        start_pos = Player.GetComponent<Transform>().position;

        stage = GameObject.Find("stageReturn");
        StageScript = stage.GetComponent<stage_test_script>();

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //　主人公の方向
            var playerDirection = other.transform.position - transform.position;
            //　敵の前方からの主人公の方向
            var angle = Vector3.Angle(transform.forward, playerDirection);
            //　サーチする角度内だったら発見
            if (angle <= searchAngle)
            {
                Debug.Log("主人公発見: " + angle);
                //onlyForwardSearchEnemy.SetState(WatchTower.EnemyState.Chase, other.transform);

                if(StageScript.isLight_Flg == false)
                {
                     Player.GetComponent<Transform>().position = start_pos;
                }


                // 見つかった時の音再生
                //audio_source.PlayOneShot(se_WatchTower);
            }
        }
    }

#if UNITY_EDITOR
    //　サーチする角度表示
    void OnDrawGizmos()
    {
        Handles.color = Color.red;
        Handles.DrawSolidArc(transform.position, Vector3.up, Quaternion.Euler(0f, -searchAngle, 0f) * transform.forward, searchAngle * 2f, searchArea.radius);
    }
#endif

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        onlyForwardSearchEnemy.SetState(WatchTower.EnemyState.Wait);
    //    }
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    //接触したオブジェクトのタグが"Player"のとき
    //    if (other.CompareTag("Player"))
    //    {
    //        SceneManager.LoadScene("TitleScene");
    //    }
    //}
}