using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    private int index = 0;
    private int o_max = 1;


    public GameObject player;
    public GameObject Light;

    //public GameObject[] childObject;

    GameObject[] CharacterList;

    // Start is called before the first frame update
    void Start()
    {

        CharacterList = new GameObject[] { player, Light };
        //o_max = this.transform.childCount;//子オブジェクの個数取得
        //childObject = new GameObject[o_max];//インスタンス取得

        //for (int index = 0; index < o_max; index++)
        //{
        //    childObject[index] = transform.GetChild(index).gameObject;
        //}

        //foreach (GameObject gameObj in childObject)
        //{
        //    gameObj.SetActive(false);
        //}
        //childObject[index].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CharacterList[index].SetActive(false);
            index++;


            if (index == o_max) { index = 0; }

            CharacterList[index].SetActive(true);

        }
    }
}
