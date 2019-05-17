using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class Timar : MonoBehaviour
{
    //時間を4桁まで表示する
    [SerializeField]
    Image[] images = new Image[4];

    //0～9までの数字を表示する
    [SerializeField]
    Sprite[] numberSprites = new Sprite[10];
    //クリアまでの時間を計測する
    public   float timeCount { get; private set; }
    public static int timepoint;
    public static int timepoint2;
    public static int timepoint3;
    public static int timepoint4;
    public static int timepoint5;
    public static int timepoint6;
    // Start is called before the first frame update
    void Start()
    {
        //タイマースタート
        SetTime(0);
    }
    //クリア時間を計測する
    public void SetTime(float time)
    {
        timeCount = time;
        StartCoroutine(TimerStart());
    }
    //タイマーに使う画像を表示する
    void SetNumbers(int sec, int val1, int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[Convert.ToInt32(str.Substring(0, 1))];
        images[val2].sprite = numberSprites[Convert.ToInt32(str.Substring(1, 1))];
    }
    //タイマーに合わせて画像を更新する
    IEnumerator TimerStart()
    {
        while (timeCount >= 0)
        {
            int sec = Mathf.FloorToInt(timeCount % 60);
            SetNumbers(sec, 2, 3);
            int minu = Mathf.FloorToInt((timeCount -sec) / 60);
            SetNumbers(minu, 0, 1);
         
            yield return new WaitForSeconds(1.0f);
            timeCount += 1.0f;
            //シーン名を第１ステージのシーン名に変えて下さい
            if(SceneManager.GetActiveScene().name=="MAIN")
            timepoint = (int)timeCount;
            //シーン名を第２ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 2")
                timepoint2 = (int)timeCount;
            //シーン名を第３ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 3")
                timepoint3 = (int)timeCount;
            //シーン名を第４ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 4")
                timepoint4 = (int)timeCount;
            //シーン名を第５ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 5")
                timepoint5 = (int)timeCount;
            //シーン名を第６ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 6")
                timepoint6 = (int)timeCount;
            //Debug.Log(timeCount);

        }
    
    }

   
    // Update is called once per frame
    void Update()
    {
        //シーン遷移の条件を変えてください
        //リザルトシーンに移動する
        if (Input.GetKeyDown(KeyCode.S))
        {
            
              //シーン名を第１ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN")
                SceneManager.LoadScene("result");
            //シーン名を第２ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 2")
                SceneManager.LoadScene("result 2");
            //シーン名を第３ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 3")
                SceneManager.LoadScene("result 3");
            //シーン名を第４ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 4")
                SceneManager.LoadScene("result 4");
            //シーン名を第５ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 5")
                SceneManager.LoadScene("result 5");
            //シーン名を第６ステージのシーン名に変えて下さい
            if (SceneManager.GetActiveScene().name == "MAIN 6")
                SceneManager.LoadScene("result 6");

        }
    }
}
