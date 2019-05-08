using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    [SerializeField, Header("表示させるテキスト")]
    Text[] rankingText = new Text[5];

    // Start is called before the first frame update
    void Start()
    {
        //クリア時間が0ならば1時間にする
        if (point == 0)
        {
            point = 3600;
        }
        //PlayerPrefs.DeleteAll();
        //ランキング呼び出し
        GetRanking();
        //ランキングを書き込む
        SetRanking(point);
        for (int i = 0; i < rankingText.Length; i++)
        {
         
           //ランキング表示
            minute[i] = (int)rankingValue[i] / 60;
            second[i] = rankingValue[i] - minute[i] * 60;
            rankingText[i].text = (i + 1) + "位" + minute[i].ToString("00") + ";" + ((int)second[i]).ToString("00");
            //クリア時間が0や1時間ならば表示しない
            if (rankingValue[i] == 0 || rankingValue[i] == 3600)
            {
                rankingText[i].text = (i+1)+"位"+"-------";

            }
        }
    
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
