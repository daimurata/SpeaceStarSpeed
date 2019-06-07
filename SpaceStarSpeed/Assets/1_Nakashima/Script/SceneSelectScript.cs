using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SceneSelectScript : MonoBehaviour
{
    //シーンの選択中に必要な処理を追加していく
    //ここにobjをアタッチしていってそれを消したりしてく 6個
    public GameObject[] childStageObj = new GameObject[6];

    private GameObject gogo;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //呼ぶ
        StageSelect();   
    }
    void StageSelect()
    {
        //ステージの名前を入れていく（Inspectorだと編集めんどいからここに書き込み）
        //ステージの名前とステージ選択のボタンの名前は同じにしていく、統一させて分かりやすく
        GameObject stg1 = GameObject.Find("Stage1");
        GameObject stg2 = GameObject.Find("Stage2");
        GameObject stg3 = GameObject.Find("Stage3");
        GameObject stg4 = GameObject.Find("Stage4");
        GameObject stg5 = GameObject.Find("Stage5");
        GameObject stg6 = GameObject.Find("Stage6"); //これ以上は増やさないし、増やせない

        //選択中のGameObjectを取得
        GameObject go = EventSystem.current.currentSelectedGameObject;


        ////Stage1のobjをtrueにする
        //if (go == stg1)
        //{
        //    childStageObj[0].SetActive(true);
        //    //Stage1以外のobjをfalse
        //    childStageObj[1].SetActive(false);
        //    childStageObj[2].SetActive(false);
        //    childStageObj[3].SetActive(false);
        //    childStageObj[4].SetActive(false);
        //    childStageObj[5].SetActive(false);
        //}
        ////Stage2のobjをtrueにする
        //if (go == stg2)
        //{
        //    childStageObj[1].SetActive(true);
        //    //Stage2以外のobjをfalse
        //    childStageObj[0].SetActive(false);
        //    childStageObj[2].SetActive(false);
        //    childStageObj[3].SetActive(false);
        //    childStageObj[4].SetActive(false);
        //    childStageObj[5].SetActive(false);
        //}
        ////Stage3のobjをtrueにする
        //if (go == stg3)
        //{
        //    childStageObj[2].SetActive(true);
        //    //Stage3以外のobjをfalse
        //    childStageObj[0].SetActive(false);
        //    childStageObj[1].SetActive(false);
        //    childStageObj[3].SetActive(false);
        //    childStageObj[4].SetActive(false);
        //    childStageObj[5].SetActive(false);
        //}
        ////Stage4のobjをtrueにする
        //if (go == stg4)
        //{
        //    childStageObj[3].SetActive(true);
        //    //Stage4以外のobjをfalse
        //    childStageObj[0].SetActive(false);
        //    childStageObj[1].SetActive(false);
        //    childStageObj[2].SetActive(false);
        //    childStageObj[4].SetActive(false);
        //    childStageObj[5].SetActive(false);
        //}
        ////Stage5のobjをtrueにする
        //if (go == stg5)
        //{
        //    childStageObj[4].SetActive(true);
        //    //Stage5以外のobjをfalse
        //    childStageObj[0].SetActive(false);
        //    childStageObj[1].SetActive(false);
        //    childStageObj[2].SetActive(false);
        //    childStageObj[3].SetActive(false);
        //    childStageObj[5].SetActive(false);
        //}
        ////Stage6のobjをtrueにする
        //if (go == stg6)
        //{
        //    childStageObj[5].SetActive(true);
        //    //Stage6以外のobjをfalse
        //    childStageObj[0].SetActive(false);
        //    childStageObj[1].SetActive(false);
        //    childStageObj[2].SetActive(false);
        //    childStageObj[3].SetActive(false);
        //    childStageObj[4].SetActive(false);
        //}
        //Debug.Log(go);
    }
}
