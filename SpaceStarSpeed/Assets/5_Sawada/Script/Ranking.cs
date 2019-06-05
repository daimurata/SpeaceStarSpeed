using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class Ranking : MonoBehaviour
{
    //0
    int startpoint = 0;
    //分
    int[] minute = new int[5];
    //秒
    int[] second = new int[5];
    //クリア時間
    int point=Timar.timepoint;
    int point2 = Timar.timepoint2;
    int point3 = Timar.timepoint3;
    int point4 = Timar.timepoint4;
    int point5 = Timar.timepoint5;
    int point6 = Timar.timepoint6;
    //ランキングを5位まで表示
    //下のデータを引き継ぐ
    public static  string[] ranking = { "ランキング1位", "ランキング2位", "ランキング3位", "ランキング4位", "ランキング5位" };
    public static string[] ranking2 = { "ランキング2.1位", "ランキング2.2位", "ランキング2.3位", "ランキング2.4位", "ランキング2.5位" };
    public static string[] ranking3 = { "ランキング3.1位", "ランキング3.2位", "ランキング3.3位", "ランキング3.4位", "ランキング3.5位" };
    public static string[] ranking4 = { "ランキング4.1位", "ランキング4.2位", "ランキング4.3位", "ランキング4.4位", "ランキング4.5位" };
    public static string[] ranking5 = { "ランキング5.1位", "ランキング5.2位", "ランキング5.3位", "ランキング5.4位", "ランキング5.5位" };
    public static string[] ranking6 = { "ランキング6.1位", "ランキング6.2位", "ランキング6.3位", "ランキング6.4位", "ランキング6.5位" };
    public static   int[] rankingValue = new int[5];
    public static int[] rankingValue2 = new int[5];
    public static int[] rankingValue3 = new int[5];
    public static int[] rankingValue4 = new int[5];
    public static int[] rankingValue5 = new int[5];
    public static int[] rankingValue6 = new int[5];
    //ここまでのデータを引き継ぐ
 
      //表示するイメージ
    [SerializeField]
    Image[] images = new Image[20];
    //表示するスプライト
    [SerializeField]
    Sprite[] numberSprites = new Sprite[11];
    //Newの文字を５個登録
    public  GameObject[] Newobject = new GameObject[5];
    //点滅するスピード
    public float speed = 0.5f;
    //点滅が終わるまでの時間
    private float time;
    // Start is called before the first frame update

    void Start()
    {
        
        //クリア時間が0ならば1時間にする
        if (point == 0)
        {
            point = 3600;
        }
        if (point2 == 0)
        {
            point2 = 3600;
        }
        if (point3 == 0)
        {
            point3 = 3600;
        }
        if (point4 == 0)
        {
            point4 = 3600;
        }
        if (point5 == 0)
        {
            point5 = 3600;
        }
        if (point6 == 0)
        {
            point6 = 3600;
        }
        //ランキングを初期化
       //PlayerPrefs.DeleteAll();
        //ランキング呼び出し
        GetRanking();
        //ランキングを書き込む
        SetRanking(point,point2,point3,point4,point5,point6);
        for (int i = 0; i < Newobject.Length; i++)
        {
            
            //リザルト１用
            //"  "の部分を使用するリザルト画面の名前に変える
            if (SceneManager.GetActiveScene().name == "result")
            {
                //ランキングの順位に合わせてnewの文字を表示する
                if (rankingValue[0]==point)
                {
                
                    Newobject[0].SetActive(true);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }else
                if (rankingValue[1]==point)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(true);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }else
                if (rankingValue[2]==point)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(true);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }else
                if (rankingValue[3]==point)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(true);
                    Newobject[4].SetActive(false);
                }else
                if (rankingValue[4]==point)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(true);
                }
                else
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);

                }

                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingValue[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingValue[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
             
                //クリア時間が0か100ならば何も表示しない
                if (rankingValue[0] == 0 || rankingValue[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingValue[1] == 0 || rankingValue[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingValue[2] == 0 || rankingValue[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingValue[3] == 0 || rankingValue[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingValue[4] == 0 || rankingValue[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }

            }
            //リザルト２用
            //"  "の部分を使用するリザルト画面の名前に変える
            if (SceneManager.GetActiveScene().name == "result 2")
            {
                //ランキングの順位に合わせてnewの文字を表示する
                if (rankingValue2[0] == point2)
                {
                    Newobject[0].SetActive(true);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                   if (rankingValue2[1] == point2)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(true);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                   if (rankingValue[2] == point2)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(true);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                   if (rankingValue2[3] == point2)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(true);
                    Newobject[4].SetActive(false);
                }
                else
                   if (rankingValue2[4] == point2)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(true);
                }
                else
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);

                }
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingValue2[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingValue2[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingValue2[0] == 0 || rankingValue2[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingValue2[1] == 0 || rankingValue2[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingValue2[2] == 0 || rankingValue2[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingValue2[3] == 0 || rankingValue2[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingValue2[4] == 0 || rankingValue2[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            //リザルト３用意
            //"  "の部分を使用するリザルト画面の名前に変える
            if (SceneManager.GetActiveScene().name == "result 3")
            {
                //ランキングの順位に合わせてnewの文字を表示する
                if (rankingValue3[0] == point3)
                {
                    Newobject[0].SetActive(true);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue3[1] == point3)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(true);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue3[2] == point3)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(true);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue3[3] == point3)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(true);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue3[4] == point3)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(true);
                }
                else
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);

                }

                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingValue3[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingValue3[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingValue3[0] == 0 || rankingValue3[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingValue3[1] == 0 || rankingValue3[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingValue3[2] == 0 || rankingValue3[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingValue3[3] == 0 || rankingValue3[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingValue3[4] == 0 || rankingValue3[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            //リザルト４用
            //"  "の部分を使用するリザルト画面の名前に変える
            if (SceneManager.GetActiveScene().name == "result 4")
            {
                //ランキングの順位に合わせてnewの文字を表示する
                if (rankingValue4[0] == point4)
                {
                    Newobject[0].SetActive(true);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue4[1] == point4)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(true);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue4[2] == point4)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(true);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue4[3] == point4)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(true);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue4[4] == point4)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(true);
                }
                else
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);

                }
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingValue4[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingValue4[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingValue4[0] == 0 || rankingValue4[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingValue4[1] == 0 || rankingValue4[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingValue4[2] == 0 || rankingValue4[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingValue4[3] == 0 || rankingValue4[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingValue4[4] == 0 || rankingValue4[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            //リザルト５用
            //"  "の部分を使用するリザルト画面の名前に変える
            if (SceneManager.GetActiveScene().name == "result 5")
            {
                //ランキングの順位に合わせてnewの文字を表示する
                if (rankingValue5[0] == point5)
                {
                    Newobject[0].SetActive(true);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue5[1] == point5)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(true);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue5[2] == point5)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(true);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue5[3] == point5)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(true);
                    Newobject[4].SetActive(false);
                }
                else
                  if (rankingValue5[4] == point5)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(true);
                }
                else
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);

                }
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingValue5[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingValue5[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か3600ならば何も表示しない
                if (rankingValue5[0] == 0 || rankingValue5[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingValue5[1] == 0 || rankingValue5[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingValue5[2] == 0 || rankingValue5[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingValue5[3] == 0 || rankingValue5[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingValue5[4] == 0 || rankingValue5[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            //リザルト６用
            //"  "の部分を使用するリザルト画面の名前に変える
            if (SceneManager.GetActiveScene().name == "result 6")
            {
                //ランキングの順位に合わせてnewの文字を表示する
                if (rankingValue6[0] == point6)
                {
                    Newobject[0].SetActive(true);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                 if (rankingValue6[1] == point6)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(true);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                 if (rankingValue6[2] == point6)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(true);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);
                }
                else
                 if (rankingValue6[3] == point6)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(true);
                    Newobject[4].SetActive(false);
                }
                else
                 if (rankingValue6[4] == point6)
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(true);
                }
                else
                {
                    Newobject[0].SetActive(false);
                    Newobject[1].SetActive(false);
                    Newobject[2].SetActive(false);
                    Newobject[3].SetActive(false);
                    Newobject[4].SetActive(false);

                }
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingValue6[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingValue6[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
               
                //クリア時間が0か100ならば何も表示しない
                if (rankingValue6[0] == 0 || rankingValue6[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingValue6[1] == 0 || rankingValue6[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingValue6[2] == 0 || rankingValue6[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingValue6[3] == 0 || rankingValue6[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingValue6[4] == 0 || rankingValue6[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            
            }

     
        }
     
}
    void Update()
    {
        //点滅処理
        if (SceneManager.GetActiveScene().name == "result")
        {
            if (rankingValue[0] == point)
            {
                images[0].color = GetAlphaColor(images[0].color);
                images[1].color = GetAlphaColor(images[1].color);
                images[2].color = GetAlphaColor(images[2].color);
                images[3].color = GetAlphaColor(images[3].color);
            }
            else
            if (rankingValue[1] == point)
            {
                images[4].color = GetAlphaColor(images[4].color);
                images[5].color = GetAlphaColor(images[5].color);
                images[6].color = GetAlphaColor(images[6].color);
                images[7].color = GetAlphaColor(images[7].color);
            }
            else
            if (rankingValue[2] == point)
            {
                images[8].color = GetAlphaColor(images[8].color);
                images[9].color = GetAlphaColor(images[9].color);
                images[10].color = GetAlphaColor(images[10].color);
                images[11].color = GetAlphaColor(images[11].color);
            }
            else
             if (rankingValue[3] == point)
            {
                images[12].color = GetAlphaColor(images[12].color);
                images[13].color = GetAlphaColor(images[13].color);
                images[14].color = GetAlphaColor(images[14].color);
                images[15].color = GetAlphaColor(images[15].color);
            }
            else
             if (rankingValue[4] == point)
            {
                images[16].color = GetAlphaColor(images[16].color);
                images[17].color = GetAlphaColor(images[17].color);
                images[18].color = GetAlphaColor(images[18].color);
                images[19].color = GetAlphaColor(images[19].color);
            }
        }
       
            if (SceneManager.GetActiveScene().name == "result 2")
            {
                if (rankingValue2[0] == point2)
                {
                    images[0].color = GetAlphaColor(images[0].color);
                    images[1].color = GetAlphaColor(images[1].color);
                    images[2].color = GetAlphaColor(images[2].color);
                    images[3].color = GetAlphaColor(images[3].color);
                }
                else
                if (rankingValue2[1] == point2)
                {
                    images[4].color = GetAlphaColor(images[4].color);
                    images[5].color = GetAlphaColor(images[5].color);
                    images[6].color = GetAlphaColor(images[6].color);
                    images[7].color = GetAlphaColor(images[7].color);
                }
                else
                if (rankingValue2[2] == point2)
                {
                    images[8].color = GetAlphaColor(images[8].color);
                    images[9].color = GetAlphaColor(images[9].color);
                    images[10].color = GetAlphaColor(images[10].color);
                    images[11].color = GetAlphaColor(images[11].color);
                }
                else
                 if (rankingValue2[3] == point2)
                {
                    images[12].color = GetAlphaColor(images[12].color);
                    images[13].color = GetAlphaColor(images[13].color);
                    images[14].color = GetAlphaColor(images[14].color);
                    images[15].color = GetAlphaColor(images[15].color);
                }
                else
                 if (rankingValue2[4] == point2)
                {
                    images[16].color = GetAlphaColor(images[16].color);
                    images[17].color = GetAlphaColor(images[17].color);
                    images[18].color = GetAlphaColor(images[18].color);
                    images[19].color = GetAlphaColor(images[19].color);
                }
            }
            if (SceneManager.GetActiveScene().name == "result 3")
            {
                if (rankingValue3[0] == point3)
                {
                    images[0].color = GetAlphaColor(images[0].color);
                    images[1].color = GetAlphaColor(images[1].color);
                    images[2].color = GetAlphaColor(images[2].color);
                    images[3].color = GetAlphaColor(images[3].color);
                }
                else
                if (rankingValue3[1] == point3)
                {
                    images[4].color = GetAlphaColor(images[4].color);
                    images[5].color = GetAlphaColor(images[5].color);
                    images[6].color = GetAlphaColor(images[6].color);
                    images[7].color = GetAlphaColor(images[7].color);
                }
                else
                if (rankingValue3[2] == point3)
                {
                    images[8].color = GetAlphaColor(images[8].color);
                    images[9].color = GetAlphaColor(images[9].color);
                    images[10].color = GetAlphaColor(images[10].color);
                    images[11].color = GetAlphaColor(images[11].color);
                }
                else
                 if (rankingValue3[3] == point3)
                {
                    images[12].color = GetAlphaColor(images[12].color);
                    images[13].color = GetAlphaColor(images[13].color);
                    images[14].color = GetAlphaColor(images[14].color);
                    images[15].color = GetAlphaColor(images[15].color);
                }
                else
                 if (rankingValue3[4] == point3)
                {
                    images[16].color = GetAlphaColor(images[16].color);
                    images[17].color = GetAlphaColor(images[17].color);
                    images[18].color = GetAlphaColor(images[18].color);
                    images[19].color = GetAlphaColor(images[19].color);
                }
            }
            if (SceneManager.GetActiveScene().name == "result 4")
            {
                if (rankingValue4[0] == point4)
                {
                    images[0].color = GetAlphaColor(images[0].color);
                    images[1].color = GetAlphaColor(images[1].color);
                    images[2].color = GetAlphaColor(images[2].color);
                    images[3].color = GetAlphaColor(images[3].color);
                }
                else
                if (rankingValue4[1] == point4)
                {
                    images[4].color = GetAlphaColor(images[4].color);
                    images[5].color = GetAlphaColor(images[5].color);
                    images[6].color = GetAlphaColor(images[6].color);
                    images[7].color = GetAlphaColor(images[7].color);
                }
                else
                if (rankingValue4[2] == point4)
                {
                    images[8].color = GetAlphaColor(images[8].color);
                    images[9].color = GetAlphaColor(images[9].color);
                    images[10].color = GetAlphaColor(images[10].color);
                    images[11].color = GetAlphaColor(images[11].color);
                }
                else
                 if (rankingValue4[3] == point4)
                {
                    images[12].color = GetAlphaColor(images[12].color);
                    images[13].color = GetAlphaColor(images[13].color);
                    images[14].color = GetAlphaColor(images[14].color);
                    images[15].color = GetAlphaColor(images[15].color);
                }
                else
                 if (rankingValue4[4] == point4)
                {
                    images[16].color = GetAlphaColor(images[16].color);
                    images[17].color = GetAlphaColor(images[17].color);
                    images[18].color = GetAlphaColor(images[18].color);
                    images[19].color = GetAlphaColor(images[19].color);
                }
            }
            if (SceneManager.GetActiveScene().name == "result 5")
            {
                if (rankingValue5[0] == point5)
                {
                    images[0].color = GetAlphaColor(images[0].color);
                    images[1].color = GetAlphaColor(images[1].color);
                    images[2].color = GetAlphaColor(images[2].color);
                    images[3].color = GetAlphaColor(images[3].color);
                }
                else
                if (rankingValue5[1] == point5)
                {
                    images[4].color = GetAlphaColor(images[4].color);
                    images[5].color = GetAlphaColor(images[5].color);
                    images[6].color = GetAlphaColor(images[6].color);
                    images[7].color = GetAlphaColor(images[7].color);
                }
                else
                if (rankingValue5[2] == point5)
                {
                    images[8].color = GetAlphaColor(images[8].color);
                    images[9].color = GetAlphaColor(images[9].color);
                    images[10].color = GetAlphaColor(images[10].color);
                    images[11].color = GetAlphaColor(images[11].color);
                }
                else
                 if (rankingValue5[3] == point5)
                {
                    images[12].color = GetAlphaColor(images[12].color);
                    images[13].color = GetAlphaColor(images[13].color);
                    images[14].color = GetAlphaColor(images[14].color);
                    images[15].color = GetAlphaColor(images[15].color);
                }
                else
                 if (rankingValue5[4] == point5)
                {
                    images[16].color = GetAlphaColor(images[16].color);
                    images[17].color = GetAlphaColor(images[17].color);
                    images[18].color = GetAlphaColor(images[18].color);
                    images[19].color = GetAlphaColor(images[19].color);
                }
            }
            if (SceneManager.GetActiveScene().name == "result 6")
            {
                if (rankingValue6[0] == point6)
                {
                    images[0].color = GetAlphaColor(images[0].color);
                    images[1].color = GetAlphaColor(images[1].color);
                    images[2].color = GetAlphaColor(images[2].color);
                    images[3].color = GetAlphaColor(images[3].color);
                }
                else
                if (rankingValue6[1] == point6)
                {
                    images[4].color = GetAlphaColor(images[4].color);
                    images[5].color = GetAlphaColor(images[5].color);
                    images[6].color = GetAlphaColor(images[6].color);
                    images[7].color = GetAlphaColor(images[7].color);
                }
                else
                if (rankingValue6[2] == point6)
                {
                    images[8].color = GetAlphaColor(images[8].color);
                    images[9].color = GetAlphaColor(images[9].color);
                    images[10].color = GetAlphaColor(images[10].color);
                    images[11].color = GetAlphaColor(images[11].color);
                }
                else
                 if (rankingValue6[3] == point6)
                {
                    images[12].color = GetAlphaColor(images[12].color);
                    images[13].color = GetAlphaColor(images[13].color);
                    images[14].color = GetAlphaColor(images[14].color);
                    images[15].color = GetAlphaColor(images[15].color);
                }
                else
                 if (rankingValue6[4] == point6)
                {
                    images[16].color = GetAlphaColor(images[16].color);
                    images[17].color = GetAlphaColor(images[17].color);
                    images[18].color = GetAlphaColor(images[18].color);
                    images[19].color = GetAlphaColor(images[19].color);
                }
            }
        
        }

            //スプライトを表示
            void SetNumbers(int sec, int val1,int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[Convert.ToInt32(str.Substring(0, 1))];
        images[val2].sprite = numberSprites[Convert.ToInt32(str.Substring(1, 1))];
        }
    //何も表示しない時のスプライト
    void setnumber0(int sec,int val1,int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[10];
        images[val2].sprite = numberSprites[10];


    }
    void GetRanking()
    {
        //ステージ１のランキング呼び出し
        for (int i = 0; i < ranking.Length; i++)
        {

          
            rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);

        }
        //ステージ２のランキング呼び出し
        for (int i = 0; i < ranking2.Length; i++)
        {


            rankingValue2[i] = PlayerPrefs.GetInt(ranking2[i]);

        }
        //ステージ３のランキング呼び出し
        for (int i = 0; i < ranking3.Length; i++)
        {


            rankingValue3[i] = PlayerPrefs.GetInt(ranking3[i]);

        }
        //ステージ４のランキング呼び出し
        for (int i = 0; i < ranking4.Length; i++)
        {


            rankingValue4[i] = PlayerPrefs.GetInt(ranking4[i]);

        }
        //ステージ５のランキング呼び出し
        for (int i = 0; i < ranking5.Length; i++)
        {


            rankingValue5[i] = PlayerPrefs.GetInt(ranking5[i]);

        }
        //ステージ６のランキング呼び出し
        for (int i = 0; i < ranking6.Length; i++)
        {


            rankingValue6[i] = PlayerPrefs.GetInt(ranking6[i]);

        }
    }
    void SetRanking(int _value, int _value2, int _value3, int _value4, int _value5, int _value6)
    {

        //ステージ１のランキングの書き込み用
        for (int i = 0; i < ranking.Length; i++)
        {
            //ランキングに0が登録されていたら0を無視して新しい記録を入れる
            if (_value * rankingValue[i] == startpoint)
            {
            


                var chand = rankingValue[i];
                rankingValue[i] = _value;
                 _value = chand;
               
            }
            else
            {
                //ランキングに記載されていた数よりも小さければランキングを更新する
                if (_value < rankingValue[i])
                {
                   
                    var change = rankingValue[i];
                    rankingValue[i] = _value;
                   _value =change;
                }
            }
        }
    
        
        //ステージ２のランキングの書き込み用
        for (int i = 0; i < ranking2.Length; i++)
        {
            //ランキングに0が登録されていたら0を無視して新しい記録を入れる
            if (_value2 * rankingValue2[i] == startpoint)
            {
                var change = rankingValue2[i];
                rankingValue2[i] = _value2;
              
                
                _value2 = change;
            }
            else
            {
                //ランキングに記載されていた数よりも小さければランキングを更新する
                if (_value2 < rankingValue2[i])
                {
                  
                    var change = rankingValue2[i];
                    rankingValue2[i] = _value2;
                 
                   
                    _value2 = change;

                }
            }
            

        }
        //ステージ３のランキングの書き込み用
        for (int i = 0; i < ranking3.Length; i++)
        {
            //ランキングに0が登録されていたら0を無視して新しい記録を入れる
            if (_value3 * rankingValue3[i] == startpoint)
            {
                var change = rankingValue3[i];
                rankingValue3[i] = _value3;
              
             
                _value3 = change;
            }
            else
            {
                //ランキングに記載されていた数よりも小さければランキングを更新する
                if (_value3 < rankingValue3[i])
                {
                    var chand = rankingValue3[i];
                    rankingValue3[i] = _value3;
                  
                   
                    _value3 = chand;
                }
            }
            

        }
        //ステージ４のランキングの書き込み用
        for (int i = 0; i < ranking4.Length; i++)
        {
            //ランキングに0が登録されていたら0を無視して新しい記録を入れる
            if (_value4 * rankingValue4[i] == startpoint)
            {
                var change = rankingValue4[i];
                rankingValue4[i] = _value4;
              
              
                _value4 = change;
            }
            else {
                //ランキングに記載されていた数よりも小さければランキングを更新する
                if (_value4 < rankingValue4[i])
                {
                    var change = rankingValue4[i];
                    rankingValue4[i] = _value4;
                  
                  
                   
                    _value4 = change;
                }

                
            }

        }
        //ステージ５のランキングの書き込み用
        for (int i = 0; i < ranking5.Length; i++)
        {
            //ランキングに0が登録されていたら0を無視して新しい記録を入れる
            if (_value5 * rankingValue5[i] == startpoint)
            {
                var change = rankingValue5[i];
                rankingValue5[i] = _value5;
             
                _value5 = change;
            }
            else {
                //ランキングに記載されていた数よりも小さければランキングを更新する
                if (_value5 < rankingValue5[i])
                {
                    var change = rankingValue5[i];
                    rankingValue5[i] = _value5;
                  
                   
                    _value5 = change;
                }
                  
                
            }

        }
        //ステージ６のランキングの書き込み用
        for (int i = 0; i < ranking6.Length; i++)
        {
            //ランキングに0が登録されていたら0を無視して新しい記録を入れる
            if (_value6 * rankingValue6[i] == startpoint)
            {
                var change = rankingValue6[i];
                rankingValue6[i] = _value6;
                
              
                _value6 = change;
            }
            else
            {
                //ランキングに記載されていた数よりも小さければランキングを更新する
                if (_value6 < rankingValue6[i])
                {
                    var change = rankingValue6[i];
                    rankingValue6[i] = _value6;
                
                 
                    _value6 = change;

                }

            }
        }



        //ステージ１のランキングの入れ替えた値を保存
        for (int i = 0; i < ranking.Length; i++)
        {
            
            PlayerPrefs.SetInt(ranking[i],rankingValue[i]);
        
           
        }
        //ステージ２のランキングの入れ替えた値を保存
        for (int i = 0; i < ranking2.Length; i++)
        {
            PlayerPrefs.SetInt(ranking2[i], rankingValue2[i]);


        }
        //ステージ３のランキングの入れ替えた値を保存
        for (int i = 0; i < ranking3.Length; i++)
        {
          
            PlayerPrefs.SetInt(ranking3[i], rankingValue3[i]);


        }
        //ステージ４のランキングの入れ替えた値を保存
        for (int i = 0; i < ranking4.Length; i++)
        {
            PlayerPrefs.SetInt(ranking4[i], rankingValue4[i]);


        }
        //ステージ５のランキングの入れ替えた値を保存
        for (int i = 0; i < ranking5.Length; i++)
        {
            
            PlayerPrefs.SetInt(ranking5[i], rankingValue5[i]);


        }
        //ステージ６のランキングの入れ替えた値を保存
        for (int i = 0; i < ranking6.Length; i++)
        {
          
            PlayerPrefs.SetInt(ranking6[i], rankingValue6[i]);


        }
    }
    //Alpha値を更新してColorを返す
    Color GetAlphaColor(Color color)
    {
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
    // Update is called once per frame

}
