using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// YESとNOの点滅
/// </summary>
public class Select_Message : MonoBehaviour
{
    //数
    public int Number;
    //画像【本体】【輪郭】【エフェクト】
    public Image[] Blink_Body , Blink_Contour,Blink_Effect;
    //【本体】赤,緑,青,α値
    public float[] Red_Body, Green_Body, Blue_Body, Alpha_Body;
    //【輪郭】赤,緑,青,α値
    public float[] Red_Contour, Green_Contour, Blue_Contour, Alpha_Contour;
    //【エフェクト】赤,緑,青,α値
    public float[] Red_Effect, Green_Effect, Blue_Efect, Alpha_Effect;

    //時間
    public float[] Speed_Body , Speed_Contour , Speed_Effect ;

    //切替
    public bool[] Change_Body, Change_Contour, Change_Effect;

    private float Color_MAX=255.0f;

    /// <summary>
    /// 【本体】【初期設定】
    /// </summary>
    //赤色初期設定【本体】
    void Red_Color_Body()
    {
        //Numberの数ループ
        for (int i=0;i<Number;++i)
        {
            Red_Body[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //緑色初期設定【本体】
    void Green_Color_Body()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Green_Body[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //青色初期設定【本体】
    void Blue_Color_Body()
    {        
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Blue_Body[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //α値初期設定【本体】
    void Alpha_Color_Body()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Alpha_Body[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //【本体】初期設定
    void Body_Set()
    {
        //Red_Color_Body();//赤
        //Green_Color_Body();//緑
        //Blue_Color_Body();//青
        Alpha_Color_Body();//α値
    }
   
    /// <summary>
    /// 【輪郭】【初期設定】
    /// </summary>
    //赤色初期設定【輪郭】
    void Red_Color_Contour()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Red_Contour[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //緑初期設定【輪郭】
    void Green_Color_Contour()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Green_Contour[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //青初期設定【輪郭】
    void Blue_Color_Contour()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Blue_Contour[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //α値初期設定【輪郭】
    void Alpha_Color_Contour()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Alpha_Contour[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //【輪郭】初期設定
    void Contour_Set()
    {
       // Red_Color_Contour();//赤
       // Green_Color_Contour();//緑
       // Blue_Color_Contour();//青
        Alpha_Color_Contour();//α値
    }
    /// <summary>
    /// 【エフェクト】【初期設定】
    /// </summary>
    //赤初期設定【エフェクト】
    void Red_Color_Effect()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Red_Effect[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //緑初期設定【エフェクト】
    void Green_Color_Effect()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Green_Effect[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //青初期設定【エフェクト】
    void Blue_Color_Effect()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Blue_Efect[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //α値初期設定【エフェクト】
    void Alpha_Color_Effect()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Alpha_Effect[i] = 1.0f;//文字
        }
        return;//繰り返し
    }
    //【エフェクト】初期設定
    void Effect_Set()
    {
       // Red_Color_Effect();//赤
       // Green_Color_Effect();//緑
       // Blue_Color_Effect();//青
        Alpha_Color_Effect();//α値
    }
    
    
    //反映【本体】
    void Body_Standby()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Blink_Body[i].color = new Color(Red_Body[i] / Color_MAX, Green_Body[i] / Color_MAX, Blue_Body[i] / Color_MAX, Alpha_Body[i]);//文字
        }
        return;//繰り返し

    }
    //反映【輪郭】
    void Contour_Standby()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Blink_Contour[i].color = new Color(Red_Contour[i] / Color_MAX, Green_Contour[i] / Color_MAX, Blue_Contour[i] / Color_MAX, Alpha_Contour[i]);//文字
        }
        return;//繰り返し
    }
    //反映【エフェクト】
    void Effect_Standby()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Blink_Effect[i].color = new Color(Red_Effect[i] / Color_MAX, Green_Effect[i] / Color_MAX, Blue_Efect[i] / Color_MAX, Alpha_Effect[i]);//文字
        }
        return;//繰り返し
    }
    //初期
    void Start()
    {
        //色の初期【本体】
        Body_Set();
        //反映【本体】
        Body_Standby();

        //色の初期【輪郭】
        Contour_Set();
        //反映【輪郭】
        Contour_Standby();

        //色の初期【エフェクト】
        Effect_Set();
        //反映【エフェクト】
        Effect_Standby();
    }

    
    void Update()
    {
        //点滅表示【本体】
        Blink_Body_Set();
        //点滅表示【輪郭】
        Blink_Contour_Set();
        //点滅表示【エフェクト】
        Blink_Effect_Set();
    }
    /// <summary>
    /// 【点滅】【本体】
    /// </summary>
    //【点滅】【本体】【0】
    void Blink_Zero_Body_Text()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            //trueなら
            if (Change_Body[i] == true)
            {
                //α値を下げる
                Alpha_Body[i] -= Speed_Body[i] * Time.deltaTime;
                //α値が0以下なら
                if (Alpha_Body[i] < 0)
                {
                    //α値を0
                    Alpha_Body[i] = 0.0f;
                    //点滅切替
                    Change_Body[i] = false;
                }
            }
            //falseなら
            if (Change_Body[i] == false)
            {
                //α値を上げる
                Alpha_Body[i] += Speed_Body[i] * Time.deltaTime;
                //α値が1以上なら
                if (Alpha_Body[i] > 1)
                {
                    //α値を1
                    Alpha_Body[i] = 1.0f;
                    //点滅切替
                    Change_Body[i] = true;
                }
            }
        }
        return;//繰り返し
    }
    ////【点滅】【本体】【1】
    //void Blink_One_Body_Text()
    //{
    //    //trueなら
    //    if (Change_Body[1] == true)
    //    {
    //        //α値を下げる
    //        Alpha_Body[1] -= Speed_Body[1] * Time.deltaTime;
    //        //α値が0以下なら
    //        if (Alpha_Body[1] < 0)
    //        {
    //            //α値を0
    //            Alpha_Body[1] = 0.0f;
    //            //点滅切替
    //            Change_Body[1] = false;
    //        }
    //    }
    //    //falseなら
    //    if (Change_Body[1] == false)
    //    {
    //        //α値を上げる
    //        Alpha_Body[1] += Speed_Body[1] * Time.deltaTime;
    //        //α値が1以上なら
    //        if (Alpha_Body[1] > 1)
    //        {
    //            //α値を1
    //            Alpha_Body[1] = 1.0f;
    //            //点滅切替
    //            Change_Body[1] = true;
    //        }
    //    }
    //}
    ////【点滅】【本体】【2】
    //void Blink_Second_Body_Text()
    //{
    //    //trueなら
    //    if (Change_Body[2] == true)
    //    {
    //        //α値を下げる
    //        Alpha_Body[2] -= Speed_Body[2] * Time.deltaTime;
    //        //α値が0以下なら
    //        if (Alpha_Body[2] < 0)
    //        {
    //            //α値を0
    //            Alpha_Body[2] = 0.0f;
    //            //点滅切替
    //            Change_Body[2] = false;
    //        }
    //    }
    //    //falseなら
    //    if (Change_Body[2] == false)
    //    {
    //        //α値を上げる
    //        Alpha_Body[2] += Speed_Body[2] * Time.deltaTime;
    //        //α値が1以上なら
    //        if (Alpha_Body[2] > 1)
    //        {
    //            //α値を1
    //            Alpha_Body[2] = 1.0f;
    //            //点滅切替
    //            Change_Body[2] = true;
    //        }
    //    }
    //}
    //【点滅】【本体】【集合】
    void Blink_Body_Set()
    {
        //反映
        Body_Standby();
        //【点滅】【本体】【0】
        Blink_Zero_Body_Text();
    }

    /// <summary>
    /// 【点滅】【輪郭】
    /// </summary>
    //【点滅】【輪郭】【0】
    void Blink_Zero_Contour_Text()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            //trueなら
            if (Change_Contour[i] == true)
            {
                //α値を下げる
                Alpha_Contour[i] -= Speed_Contour[i] * Time.deltaTime;
                //α値が0以下なら
                if (Alpha_Contour[i] < 0)
                {
                    //α値を0
                    Alpha_Contour[i] = 0.0f;
                    //点滅切替
                    Change_Contour[i] = false;
                }
            }
            //falseなら
            if (Change_Contour[i] == false)
            {
                //α値を上げる
                Alpha_Contour[i] += Speed_Contour[i] * Time.deltaTime;
                //α値が1以上なら
                if (Alpha_Contour[i] > 1)
                {
                    //α値を1
                    Alpha_Contour[i] = 1.0f;
                    //点滅切替
                    Change_Contour[i] = true;
                }
            }
        }
        return;//繰り返し
    }
    ////【点滅】【輪郭】【1】
    //void Blink_One_Contour_Text()
    //{
    //    //trueなら
    //    if (Change_Contour[1] == true)
    //    {
    //        //α値を下げる
    //        Alpha_Contour[1] -= Speed_Contour[1] * Time.deltaTime;
    //        //α値が0以下なら
    //        if (Alpha_Contour[1] < 0)
    //        {
    //            //α値を0
    //            Alpha_Contour[1] = 0.0f;
    //            //点滅切替
    //            Change_Contour[1] = false;
    //        }
    //    }
    //    //falseなら
    //    if (Change_Contour[1] == false)
    //    {
    //        //α値を上げる
    //        Alpha_Contour[1] += Speed_Contour[1] * Time.deltaTime;
    //        //α値が1以上なら
    //        if (Alpha_Contour[1] > 1)
    //        {
    //            //α値を1
    //            Alpha_Contour[1] = 1.0f;
    //            //点滅切替
    //            Change_Contour[1] = true;
    //        }
    //    }
    //}
    ////【点滅】【輪郭】【2】
    //void Blink_Second_Contour_Text()
    //{
    //    //trueなら
    //    if (Change_Contour[2] == true)
    //    {
    //        //α値を下げる
    //        Alpha_Contour[2] -= Speed_Contour[2] * Time.deltaTime;
    //        //α値が0以下なら
    //        if (Alpha_Contour[2] < 0)
    //        {
    //            //α値を0
    //            Alpha_Contour[2] = 0.0f;
    //            //点滅切替
    //            Change_Contour[2] = false;
    //        }
    //    }
    //    //falseなら
    //    if (Change_Contour[2] == false)
    //    {
    //        //α値を上げる
    //        Alpha_Contour[2] += Speed_Contour[2] * Time.deltaTime;
    //        //α値が1以上なら
    //        if (Alpha_Contour[2] > 1)
    //        {
    //            //α値を1
    //            Alpha_Contour[2] = 1.0f;
    //            //点滅切替
    //            Change_Contour[2] = true;
    //        }
    //    }
    //}
    //【点滅】【輪郭】【集合】
    void Blink_Contour_Set()
    {
        //反映
        Contour_Standby();
        //【点滅】【輪郭】【0】
        Blink_Zero_Contour_Text();
        
    }

    /// <summary>
    /// 【点滅】【エフェクト】
    /// </summary>
    //【点滅】【エフェクト】【0】
    void Blink_Zero_Effect_Text()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            //trueなら
            if (Change_Effect[i] == true)
            {
                //α値を下げる
                Alpha_Effect[i] -= Speed_Effect[i] * Time.deltaTime;
                //α値が0以下なら
                if (Alpha_Effect[i] < 0)
                {
                    //α値を0
                    Alpha_Effect[i] = 0.0f;
                    //点滅切替
                    Change_Effect[i] = false;
                }
            }
            //falseなら
            if (Change_Effect[i] == false)
            {
                //α値を上げる
                Alpha_Effect[i] += Speed_Effect[i] * Time.deltaTime;
                //α値が1以上なら
                if (Alpha_Effect[i] > 1)
                {
                    //α値を1
                    Alpha_Effect[i] = 1.0f;
                    //点滅切替
                    Change_Effect[i] = true;
                }
            }
        }
        return;//繰り返し
    }
    ////【点滅】【エフェクト】【1】
    //void Blink_One_Effect_Text()
    //{
    //    //trueなら
    //    if (Change_Effect[1] == true)
    //    {
    //        //α値を下げる
    //        Alpha_Effect[1] -= Speed_Effect[1] * Time.deltaTime;
    //        //α値が0以下なら
    //        if (Alpha_Effect[1] < 0)
    //        {
    //            //α値を0
    //            Alpha_Effect[1] = 0.0f;
    //            //点滅切替
    //            Change_Effect[1] = false;
    //        }
    //    }
    //    //falseなら
    //    if (Change_Effect[1] == false)
    //    {
    //        //α値を上げる
    //        Alpha_Effect[1] += Speed_Effect[1] * Time.deltaTime;
    //        //α値が1以上なら
    //        if (Alpha_Effect[1] > 1)
    //        {
    //            //α値を1
    //            Alpha_Effect[1] = 1.0f;
    //            //点滅切替
    //            Change_Effect[1] = true;
    //        }
    //    }
    //}
    ////【点滅】【エフェクト】【2】
    //void Blink_Second_Effect_Text()
    //{
    //    //trueなら
    //    if (Change_Effect[2] == true)
    //    {
    //        //α値を下げる
    //        Alpha_Effect[2] -= Speed_Effect[2] * Time.deltaTime;
    //        //α値が0以下なら
    //        if (Alpha_Effect[2] < 0)
    //        {
    //            //α値を0
    //            Alpha_Effect[2] = 0.0f;
    //            //点滅切替
    //            Change_Effect[2] = false;
    //        }
    //    }
    //    //falseなら
    //    if (Change_Effect[2] == false)
    //    {
    //        //α値を上げる
    //        Alpha_Effect[2] += Speed_Effect[2] * Time.deltaTime;
    //        //α値が1以上なら
    //        if (Alpha_Effect[2] > 1)
    //        {
    //            //α値を1
    //            Alpha_Effect[2] = 1.0f;
    //            //点滅切替
    //            Change_Effect[2] = true;
    //        }
    //    }
    //}
    ////【点滅】【エフェクト】【集合】
    void Blink_Effect_Set()
    {
        //反映
        Effect_Standby();
        //【点滅】【エフェクト】【0】
        Blink_Zero_Effect_Text();
       
    }
}
