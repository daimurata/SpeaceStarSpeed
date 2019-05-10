using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    //シーンにただ飛ばすだけ
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
}
