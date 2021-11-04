using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ǉ��������
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

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            //�@��l���̕���
            var playerDirection = other.transform.position - transform.position;
            //�@�G�̑O������̎�l���̕���
            var angle = Vector3.Angle(transform.forward, playerDirection);
            //�@�T�[�`����p�x���������甭��
            if (angle <= searchAngle)
            {
                Debug.Log("��l������: " + angle);
                //onlyForwardSearchEnemy.SetState(WatchTower.EnemyState.Chase, other.transform);
            }
        }
    }

#if UNITY_EDITOR
    //�@�T�[�`����p�x�\��
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
    //    //�ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̂Ƃ�
    //    if (other.CompareTag("Player"))
    //    {
    //        SceneManager.LoadScene("TitleScene");
    //    }
    //}
}