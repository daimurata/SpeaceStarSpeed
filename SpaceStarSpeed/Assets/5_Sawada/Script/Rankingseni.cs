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
    Text[] rankingText = new Text[5];
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
