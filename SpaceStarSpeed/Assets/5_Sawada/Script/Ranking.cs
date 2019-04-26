using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ranking : MonoBehaviour
{
    
    int[] minute = new int[5];
    int[] second = new int[5];
    int point=Scene2.scoa;
    string[] ranking = { "ランキング1位", "ランキング2位", "ランキング3位", "ランキング4位", "ランキング5位" };
    int[] rankingValue = new int[5];
    [SerializeField, Header("表示させるテキスト")]
    Text[] rankingText = new Text[5];

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        GetRanking();
        SetRanking(point);
        for (int i = 0; i < rankingText.Length; i++)
        {
            minute[i] = (int)rankingValue[i] / 60;
            second[i] = rankingValue[i] - minute[i] * 60;

            rankingText[i].text =(i+1)+"位" + minute[i].ToString("00")+";"+ ((int)second[i]).ToString("00");

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
            if (_value > rankingValue[i])
            {

                var change = rankingValue[i];
                rankingValue[i] = _value;
                _value = change;
            }
                }
            
        

        //入れ替えた値を保存
        for (int i = 0; i < ranking.Length; i++)
        {
          
            PlayerPrefs.SetInt(ranking[i], rankingValue[i]);
           

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
