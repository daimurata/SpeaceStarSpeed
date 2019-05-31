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
    string[] rankingkey2 = Ranking.ranking2;
    string[] rankingkey3 = Ranking.ranking3;
    string[] rankingkey4 = Ranking.ranking4;
    string[] rankingkey5 = Ranking.ranking5;
    string[] rankingkey6 = Ranking.ranking6;
    int[] rankingzyuni = Ranking.rankingValue;
    int[] rankingzyuni2 = Ranking.rankingValue2;
    int[] rankingzyuni3 = Ranking.rankingValue3;
    int[] rankingzyuni4 = Ranking.rankingValue4;
    int[] rankingzyuni5 = Ranking.rankingValue5;
    int[] rankingzyuni6 = Ranking.rankingValue6;

    //切替用
    public bool[] Change = new bool[6];


    // Start is called before the first frame update
    void Start()
    {
      
            for (int i = 0; i < rankingobject.Length; i++)
        {
            if (Change[0] == true)
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
                if (rankingzyuni[3] == 0 || rankingzyuni[3] == 3600)
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
           
            //ランキング表示
            if (Change[1] == true)
            {
                minute[i] = Mathf.FloorToInt((int)rankingzyuni2[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingzyuni2[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingzyuni2[0] == 0 || rankingzyuni2[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingzyuni2[1] == 0 || rankingzyuni2[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingzyuni2[2] == 0 || rankingzyuni2[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingzyuni2[3] == 0 || rankingzyuni2[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingzyuni2[4] == 0 || rankingzyuni2[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            if (Change[2] == true)
            {
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingzyuni3[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingzyuni3[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingzyuni3[0] == 0 || rankingzyuni3[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingzyuni3[1] == 0 || rankingzyuni3[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingzyuni3[2] == 0 || rankingzyuni3[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingzyuni3[3] == 0 || rankingzyuni3[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingzyuni3[4] == 0 || rankingzyuni3[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            if (Change[3] == true)
            {
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingzyuni4[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingzyuni4[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingzyuni4[0] == 0 || rankingzyuni4[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingzyuni4[1] == 0 || rankingzyuni4[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingzyuni4[2] == 0 || rankingzyuni4[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingzyuni4[3] == 0 || rankingzyuni4[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingzyuni4[4] == 0 || rankingzyuni4[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            if (Change[4] == true)
            {
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingzyuni5[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingzyuni5[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingzyuni5[0] == 0 || rankingzyuni5[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingzyuni5[1] == 0 || rankingzyuni5[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingzyuni5[2] == 0 || rankingzyuni5[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingzyuni5[3] == 0 || rankingzyuni5[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingzyuni5[4] == 0 || rankingzyuni5[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
            if (Change[5] == true)
            {
                //ランキング表示
                minute[i] = Mathf.FloorToInt((int)rankingzyuni6[i] % 60);
                SetNumbers(minute[0], 2, 3);
                SetNumbers(minute[1], 6, 7);
                SetNumbers(minute[2], 10, 11);
                SetNumbers(minute[3], 14, 15);
                SetNumbers(minute[4], 18, 19);
                second[i] = Mathf.FloorToInt((rankingzyuni6[i] - minute[i]) / 60);
                SetNumbers(second[0], 0, 1);
                SetNumbers(second[1], 4, 5);
                SetNumbers(second[2], 8, 9);
                SetNumbers(second[3], 12, 13);
                SetNumbers(second[4], 16, 17);
                //クリア時間が0か100ならば何も表示しない
                if (rankingzyuni6[0] == 0 || rankingzyuni6[0] == 3600)
                {
                    setnumber0(minute[0], 2, 3);
                    setnumber0(second[0], 0, 1);
                }
                if (rankingzyuni6[1] == 0 || rankingzyuni6[1] == 3600)
                {
                    setnumber0(minute[1], 6, 7);
                    setnumber0(second[1], 4, 5);
                }
                if (rankingzyuni6[2] == 0 || rankingzyuni6[2] == 3600)
                {
                    setnumber0(minute[2], 10, 11);
                    setnumber0(second[2], 8, 9);
                }
                if (rankingzyuni6[3] == 0 || rankingzyuni6[3] == 3600)
                {
                    setnumber0(minute[3], 14, 15);
                    setnumber0(second[3], 12, 13);
                }
                if (rankingzyuni6[4] == 0 || rankingzyuni6[4] == 3600)
                {
                    setnumber0(minute[4], 18, 19);
                    setnumber0(second[4], 16, 17);
                }
            }
        }
      
            for (int i = 0; i < rankingkey.Length; i++)
            {

                PlayerPrefs.SetInt(rankingkey[i], rankingzyuni[i]);


            }
        
    
            for (int i = 0; i < rankingkey2.Length; i++)
            {

                PlayerPrefs.SetInt(rankingkey2[i], rankingzyuni2[i]);


            }
        
 
            for (int i = 0; i < rankingkey3.Length; i++)
            {

                PlayerPrefs.SetInt(rankingkey3[i], rankingzyuni3[i]);


            }
        
    
            for (int i = 0; i < rankingkey4.Length; i++)
            {

                PlayerPrefs.SetInt(rankingkey4[i], rankingzyuni4[i]);


            }
        
    
            for (int i = 0; i < rankingkey5.Length; i++)
            {

                PlayerPrefs.SetInt(rankingkey5[i], rankingzyuni5[i]);


            }
        
    
            for (int i = 0; i < rankingkey6.Length; i++)
            {

                PlayerPrefs.SetInt(rankingkey6[i], rankingzyuni6[i]);


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
