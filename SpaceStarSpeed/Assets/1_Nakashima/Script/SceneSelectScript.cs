using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SceneSelectScript : MonoBehaviour
{
    //シーンの選択中に必要な処理を追加していく
    //子
    public GameObject[] childStageObj = new GameObject[4]; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //ここのとっちゅう

        int j = 0;
        //選択中のGameObjectを取得
        GameObject go = EventSystem.current.currentSelectedGameObject;
        foreach(Transform child in go.transform)
        {
            //childStageObj[j] = child.gameObject;
            //Stage1のobjをtrueにする
            if(j == 0)
            {
                childStageObj[j].SetActive(true);
                j++;
            }
            //Stage2のobjをtrueにする
            if (j == 1)
            {
                childStageObj[j].SetActive(true);
                j++;
            }
            //Stage3のobjをtrueにする
            if (j == 2)
            {
                childStageObj[j].SetActive(true);
                j++;
            }
            //Stage4のobjをtrueにする
            if (j == 3)
            {
                childStageObj[j].SetActive(true);
                j++;
            }
        }
        Debug.Log(go);
    }
}
