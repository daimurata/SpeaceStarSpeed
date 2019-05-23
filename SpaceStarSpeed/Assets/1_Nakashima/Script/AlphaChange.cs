﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlphaChange : MonoBehaviour
{
    //α値を変更したいテキストを入れる
    public Image ChangeText;
    //α値の初期値
    float AlphaColor = 1;
    //RGBを入れる変数
    float red, green, blue;
    //時間を入れる変数Time.deltatimeに×やつね、別々で変わる速度を変更するため
    public float time;
    //bool
    bool a_flag;
    // Start is called before the first frame update
    void Start()
    {
        //アタッチしたImageのcolorを読み込んで変数に入れる
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;

        a_flag = true;
    }

    // Update is called once per frame
    void Update()
    {
        //α値変更する場所
        ChangeText.color = new Color(red, green, blue, AlphaColor);


        if (a_flag == true)
        {
            //徐々に値から引く
            AlphaColor -= time * Time.deltaTime;
            //α値が0より下になったらfalseにする
            if (AlphaColor < 0)
            {
                //0にします
                AlphaColor = 0;
                //falseの方のif分に切り替え
                a_flag = false;
            }
        }
        if(a_flag == false)
        {
            //徐々に値を足す
            AlphaColor += time * Time.deltaTime;
            //α値が1を超えたらtrueにする
            if(AlphaColor > 1)
            {
                //1にする
                AlphaColor = 1;
                //trueの方のif分に切り替え
                a_flag = true;
            }
        }       
    }
}