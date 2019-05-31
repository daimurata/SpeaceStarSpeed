using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Rankingseni : MonoBehaviour
{

    

    //分
    int[] minute = new int[5];
    //秒
    int[] second = new int[5];
    //表示するテキスト
    [SerializeField]
    GameObject[] rankingobject = new GameObject[5];
    //表示するイメージ
    [SerializeField]
    Image[] images = new Image[20];
    //表示するスプライト
    [SerializeField]
    Sprite[] numberSprites = new Sprite[11];
    string[] rankingkey = Ranking.ranking;
    int[] rankingzyuni = Ranking.rankingValue;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < rankingobject.Length; i++)
        {
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingzyuni[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingzyuni[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingzyuni[0] == 0 || rankingzyuni[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingzyuni[1] == 0 || rankingzyuni[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingzyuni[2] == 0 || rankingzyuni[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingzyuni[3] == 0 ||rankingzyuni[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingzyuni[4] == 0 || rankingzyuni[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
           

        }
        for (int i = 0; i < rankingkey.Length; i++)
        {

            PlayerPrefs.SetInt(rankingkey[i], rankingzyuni[i]);


        }
    }
    void SetNumbers(int sec, int val1, int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[Convert.ToInt32(str.Substring(0, 1))];
        images[val2].sprite = numberSprites[Convert.ToInt32(str.Substring(1, 1))];
    }
    void setnumber0(int sec, int val1, int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[10];
        images[val2].sprite = numberSprites[10];


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
