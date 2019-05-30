using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SceneMove : MonoBehaviour
{
    GameObject fadeScriptObj;
    FadeScript fadeScript;
    void Start()
    {
        fadeScriptObj = GameObject.Find("FadeImage");
        fadeScript = fadeScriptObj.GetComponent<FadeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //これで多分スクリプトが呼び出されている
            fadeScript.FadeOutButton();
        }
    }
}
