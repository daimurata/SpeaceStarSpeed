using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// リザルトCanvas
/// </summary>
public class Result_Canvas : MonoBehaviour
{
    //数
    public int Number;

    //画像【本体】【エフェクト】
    public Image[] Blink_Body, Blink_Effect;
    //【本体】赤,緑,青,α値
    public float[] Red_Body, Green_Body, Blue_Body, Alpha_Body;
    //【エフェクト】赤,緑,青,α値
    public float[] Red_Effect, Green_Effect, Blue_Effect, Alpha_Effect;

    //時間
    public float[] Speed_Body, Speed_Effect;

    //切替
    public bool[] Change_Body, Change_Effect;

    private float Color_MAX = 255f;
    //赤【本体】
    void Red_Color_Body()
    {
        //Numberの数ループ
        for (int i=0;i<Number;++i)
        {
            //赤
            Red_Body[i] = 1.0f;
        }
        return;//繰り返す
    }
    //緑【本体】
    void Green_Color_Body()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            //緑
            Green_Body[i] = 1.0f;
        }
        return;//繰り返す
    }
    //青【本体】
    void Blue_Color_Body()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            //青
            Blue_Body[i] = 1.0f;
        }
        return;//繰り返す
    }
    //α値【本体】
    void Alpha_Color_Body()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            //α値
            Alpha_Body[i] = 1.0f;
        }
        return;//繰り返す
    }
    //RGBA【本体】セット
    void Color_Body()
    {
        //Red_Color_Body();//赤
        //Green_Color_Body();//緑
        //Blue_Color_Body();//青
        Alpha_Color_Body();//α値
    }

    //赤【エフェクト】
    void Red_Color_Effect()
    {
        //Numberの数ループ
        for (int i=0;i<Number;++i)
        {
            Red_Effect[i] = 1.0f;//赤
        }
        return;//繰り返し
    }
    //緑【エフェクト】
    void Green_Color_Effect()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Green_Effect[i] = 1.0f;//緑
        }
        return;//繰り返し
    }
    //青【エフェクト】
    void Blue_Color_Effect()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Blue_Effect[i] = 1.0f;//青
        }
        return;//繰り返し
    }
    //α値【エフェクト】
    void Alpha_Color_Effect()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            Alpha_Effect[i] = 1.0f;//青
        }
        return;//繰り返し
    }
    //赤緑青α値【エフェクト】
    void Color_Effect()
    {
        //Red_Color_Effect();//赤
        //Green_Color_Effect();//緑
        //Blue_Color_Effect();//青
        Alpha_Color_Effect();//α値
    }

    //【本体】【画像】
    void Body_Standby()
    {
        //Numberの数ループ
        for (int i=0;i<Number;++i)
        {
            //画像色
            Blink_Body[i].color = new Color(Red_Body[i] / Color_MAX, Green_Body[i] / Color_MAX, Blue_Body[i] / Color_MAX, Alpha_Body[i]);
        }
        //繰り返し
        return;
    }
    //【エフェクト】【画像】
    void Effect_Standby()
    {
        //Numberの数ループ
        for (int i = 0; i < Number; ++i)
        {
            //画像色
            Blink_Effect[i].color = new Color(Red_Effect[i] / Color_MAX, Green_Effect[i] / Color_MAX, Blue_Effect[i] / Color_MAX, Alpha_Effect[i]);
        }
        //繰り返し
        return;
    }


    void Start()
    {
        //初期【本体】
        Color_Body();
        //反映【本体】
        Body_Standby();

        //初期【エフェクト】
        Color_Effect();
        //反映【エフェクト】
        Effect_Standby();

    }


    void Update()
    {
        //【本体】
        Blink_Body_Set();
        //【エフェクト】
        Blink_Effect_Set();
    }
    //点滅【本体】
    void Blink_Body_Text()
    {
        //Numberの数ループ
        for (int i=0;i<Number;++i)
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
            if (Change_Body[i]==false)
            {
                //α値を上げる
                Alpha_Body[i] += Speed_Body[i] * Time.deltaTime;
                //α値が1以上なら
                if (Alpha_Body[i]>1)
                {
                    //α値を1
                    Alpha_Body[i] = 1.0f;
                    //点滅切替
                    Change_Body[i] = true;
                }
            }
        }
    }
    //点滅【エフェクト】
    void Blink_Effect_Text()
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
    }
    //点滅【本体】【セット】
    void Blink_Body_Set()
    {
        //反映
        Body_Standby();
        //点滅【本体】
        Blink_Body_Text();
    }
    //点滅【エフェクト】【セット】
    void Blink_Effect_Set()
    {
        //反映
        Effect_Standby();
        //点滅【本体】
        Blink_Effect_Text();
    }
}
