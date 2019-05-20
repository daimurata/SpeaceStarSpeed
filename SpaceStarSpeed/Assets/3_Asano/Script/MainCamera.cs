using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject M_Ca; //カメラ
    public GameObject player;   //Player

    public Vector3 Ca_pos;  //カメラ座標
    public Vector3 P_pos;   //Player座標
    public Vector3 offset; //Playerとカメラの距離
    private Vector3 Goal;   //ゴールカメラワーク

    void Start()
    {
        //カメラとPlayerのオブジェクト取得
        M_Ca = GameObject.Find("Main Camera");
        player = GameObject.Find("Star");

        //カメラとPlayerの距離を求める(間隔は５)
        offset = M_Ca.transform.position - player.transform.position;

        //※カメラの初期位置は今後追加予定

        //ゴール時のカメラの位置決め
        Goal = new Vector3(0, 100f, 0);
    }
    
    void LateUpdate()
    {
        
    }
    void Update()
    {
        //PlayerとMain Caneraの位置を常に把握
        //カメラはy座標のみ
        P_pos = player.transform.position;
        Ca_pos.y = player.transform.position.y;

        //カメラ　Playerに追従
        M_Ca.transform.position = Ca_pos + offset;

        //カメラが高さ200になったら
        if (Ca_pos.y < 100)
        {
            //カメラの位置を止める処理へ移動
            Ca_Stop();
        }
    }
    //カメラの位置停止
    void Ca_Stop()
    {
        Debug.Log("End of the Earth");
        //カメラを指定の座標にとどめる
        M_Ca.transform.position = Goal;
    }
}
