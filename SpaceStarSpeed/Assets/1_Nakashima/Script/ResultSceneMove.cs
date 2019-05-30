using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultSceneMove : MonoBehaviour
{
    public string[] move = new string[2];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Move1()
    {
        //シーン移動させるだけ
        SceneManager.LoadScene(move[0]);
    }
    public void Move2()
    {
        //上と同じ
        SceneManager.LoadScene(move[1]);
    }
}
