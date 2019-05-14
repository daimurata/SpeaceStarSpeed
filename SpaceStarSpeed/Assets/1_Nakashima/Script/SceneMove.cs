using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneMove : MonoBehaviour
{
    //シーンにただ飛ばす
    //シーンの名前を入力
    public string SceneName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClick()
    {
        //シーンの名前を表示してそのシーンに移動
        Debug.Log(SceneName);
        SceneManager.LoadScene(SceneName);   
    }
    
    void StarMoveCenter()
    {
        //中央に星を移動させるアニメーションを起動 
    }
    void StarMoveDefault()
    {
        //元の場所に星を戻すアニメーション
    }
}
