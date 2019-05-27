using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
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
    //ランキングを5位まで表示
    string[] ranking = { "ランキング1位", "ランキング2位", "ランキング3位", "ランキング4位", "ランキング5位" };
    int[] rankingValue = new int[5];
    [SerializeField]
    Text[] rankingText = new Text[5];
    [SerializeField]
    Image[] images = new Image[20];
    [SerializeField]
    Sprite[] numberSprites = new Sprite[11];
    // Start is called before the first frame update
    void Start()
    {
        //クリア時間が0ならば1時間にする
        if (point == 0)
        {
            point = 3600;
        }
        //ランキングを初期化
        //PlayerPrefs.DeleteAll();
        //ランキング呼び出し
        GetRanking();
        //ランキングを書き込む
        SetRanking(point);
        for (int i = 0; i < rankingText.Length; i++)
        {

         
           //ランキング表示
            minute[i] = Mathf.FloorToInt((int)rankingValue[i] % 60);
            SetNumbers(minute[0], 2, 3);
            SetNumbers(minute[1], 6, 7);
            SetNumbers(minute[2], 10, 11);
            SetNumbers(minute[3], 14, 15);
            SetNumbers(minute[4], 18, 19);
            second[i] = Mathf.FloorToInt((rankingValue[i] - minute[i]) /60);
            SetNumbers(second[0], 0,1);
            SetNumbers(second[1], 4, 5);
            SetNumbers(second[2], 8, 9);
            SetNumbers(second[3], 12, 13);
            SetNumbers(second[4], 16, 17);
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

            rankingText[i].text = (i + 1) + "位";
          
        }
     
}
    void SetNumbers(int sec, int val1,int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[Convert.ToInt32(str.Substring(0, 1))];
        images[val2].sprite = numberSprites[Convert.ToInt32(str.Substring(1, 1))];

     
        
      
     
        }
    void setnumber0(int sec,int val1,int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[10];
        images[val2].sprite = numberSprites[10];


    }
    void GetRanking()
    {
        //ランキング呼び出し
        for (int i = 0; i < ranking.Length; i++)
        {

          
            rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);

        }
    }
    void SetRanking(int _value)
    {
        
        //書き込み用
        for (int i = 0; i < ranking.Length; i++)
        {
            //ランキングに0が表示されていたら0を無視して新しい記録を入れる
            if (_value * rankingValue[i] == startpoint)
            {
                var chand =rankingValue[i];
                rankingValue[i] = _value;
                _value = chand;
              
            }
            //それ以外の場合はランキングに表示されている数よりクリア時間が短い場合はランキングを更新する
            else
            {
                if (_value < rankingValue[i])
                {



                    var change = rankingValue[i];
                    rankingValue[i] = _value;
                    _value = change;

                }
            }
            
        }
                
            
        

        //入れ替えた値を保存
        for (int i = 0; i < ranking.Length; i++)
        {
          
            PlayerPrefs.SetInt(ranking[i],rankingValue[i]);
           

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
