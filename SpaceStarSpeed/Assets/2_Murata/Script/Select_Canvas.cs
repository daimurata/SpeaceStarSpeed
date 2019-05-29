using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// セレクトSceneのStage文字に使用
/// </summary>
public class Select_Canvas : MonoBehaviour
{
    /// <summary>
    /// 反映する画像
    /// </summary>
    //ステージの文字本体
    public Image[] Stage_Body = new Image[6];
    //ステージの文字輪郭
    public Image[] Stage_Contour = new Image[6];
    //ステージの文字エフェクト
    public Image[] Stage_Effect = new Image[6];

    /// <summary>
    /// 数字変更
    /// </summary>
    //赤、緑、青、α値【母体】
    public float[] Red_Body=new float[6], Green_Body=new float[6], Blue_Body=new float[6],Alpha_Body=new float[6];
    //赤、緑、青、α値【輪郭】
    public float[] Red_Contour = new float[6], Green_Contour = new float[6], Blue_Contour = new float[6], Alpha_Contour = new float[6];
    //赤、緑、青、α値【エフェクト】
    public float[] Red_Effect = new float[6], Green_Effect = new float[6], Blue_Effect = new float[6], Alpha_Effect = new float[6];
    //時間
    public float[] Blink_Body = new float[6], Blink_Contour = new float[6], Blink_Effect = new float[6];

    //切替
    public bool[] Change_Body = new bool[6], Change_Contour = new bool[6], Change_Effect = new bool[6];

    private float Color_MAX = 255f;

    /// <summary>
    /// 母体の初期値
    /// </summary>
    //赤の初期値【母体】【赤】
    void Red_Color_Body()
    {
        Red_Body[0] = 1.0f;//数字
        Red_Body[1] = 1.0f;//s
        Red_Body[2] = 1.0f;//t
        Red_Body[3] = 1.0f;//a
        Red_Body[4] = 1.0f;//g
        Red_Body[5] = 1.0f;//e
    }
    //緑の初期値【母体】【緑】
    void Green_Color_Body()
    {
        Green_Body[0] = 1.0f;//数字
        Green_Body[1] = 1.0f;//s
        Green_Body[2] = 1.0f;//t
        Green_Body[3] = 1.0f;//a
        Green_Body[4] = 1.0f;//g
        Green_Body[5] = 1.0f;//e
    }
    //青の初期値【母体】【青】
    void Blue_Color_Body()
    {
        Blue_Body[0] = 1.0f;//数字
        Blue_Body[1] = 1.0f;//s
        Blue_Body[2] = 1.0f;//t
        Blue_Body[3] = 1.0f;//a
        Blue_Body[4] = 1.0f;//g
        Blue_Body[5] = 1.0f;//e
    }
    //α値の初期値【母体】【透明度】
    void Alpha_Color_Body()
    {
        Alpha_Body[0] = 0.0f;//数字
        Alpha_Body[1] = 0.0f;//s
        Alpha_Body[2] = 0.0f;//t
        Alpha_Body[3] = 0.0f;//a
        Alpha_Body[4] = 0.0f;//g
        Alpha_Body[5] = 0.0f;//e
    }
    //色の初期値【母体】
    void Color_Body()
    {
        //赤の初期値
        //Red_Color_Body();
        //緑の初期値
        //Green_Color_Body();
        //青の初期値
        //Blue_Color_Body();
        //α値の初期値
        Alpha_Color_Body();
    }

    /// <summary>
    /// 輪郭の初期値
    /// </summary>
    //赤の初期値【輪郭】
    void Red_Color_Contour()
    {
        Red_Contour[0] = 1.0f;//数字
        Red_Contour[1] = 1.0f;//s
        Red_Contour[2] = 1.0f;//t
        Red_Contour[3] = 1.0f;//a
        Red_Contour[4] = 1.0f;//g
        Red_Contour[5] = 1.0f;//e
    }
    //緑の初期値【輪郭】
    void Green_Color_Contour()
    {
        Green_Contour[0] = 1.0f;//数字
        Green_Contour[1] = 1.0f;//s
        Green_Contour[2] = 1.0f;//t
        Green_Contour[3] = 1.0f;//a
        Green_Contour[4] = 1.0f;//g
        Green_Contour[5] = 1.0f;//e
    }
    //青の初期値【輪郭】
    void Blue_Color_Contour()
    {
        Blue_Contour[0] = 1.0f;//数字
        Blue_Contour[1] = 1.0f;//s
        Blue_Contour[2] = 1.0f;//t
        Blue_Contour[3] = 1.0f;//a
        Blue_Contour[4] = 1.0f;//g
        Blue_Contour[5] = 1.0f;//e
    }
    //α値の初期値【輪郭】
    void Alpha_Color_Contour()
    {
        Alpha_Contour[0] = 0.0f;//数字
        Alpha_Contour[1] = 0.0f;//s
        Alpha_Contour[2] = 0.0f;//t
        Alpha_Contour[3] = 0.0f;//a
        Alpha_Contour[4] = 0.0f;//g
        Alpha_Contour[5] = 0.0f;//e
    }
    //色の初期値【輪郭】
    void Color_Contour()
    {
        //赤の初期値
        //Red_Color_Contour();
        //緑の初期値
        //Green_Color_Contour();
        //青の初期値
        //Blue_Color_Contour();
        //α値の初期値
        Alpha_Color_Contour();
    }

    /// <summary>
    /// エフェクトの初期値
    /// </summary>
    //赤の初期値【エフェクト】
    void Red_Color_Effect()
    {
        Red_Effect[0] = 1.0f;//数字
        Red_Effect[1] = 1.0f;//s
        Red_Effect[2] = 1.0f;//t
        Red_Effect[3] = 1.0f;//a
        Red_Effect[4] = 1.0f;//g
        Red_Effect[5] = 1.0f;//e
    }
    //緑の初期値【エフェクト】
    void Green_Color_Effect()
    {
        Green_Effect[0] = 1.0f;//数字
        Green_Effect[1] = 1.0f;//s
        Green_Effect[2] = 1.0f;//t
        Green_Effect[3] = 1.0f;//a
        Green_Effect[4] = 1.0f;//g
        Green_Effect[5] = 1.0f;//e
    }
    //青の初期値【エフェクト】
    void Blue_Color_Effect()
    {
        Blue_Effect[0] = 1.0f;//数字
        Blue_Effect[1] = 1.0f;//s
        Blue_Effect[2] = 1.0f;//t
        Blue_Effect[3] = 1.0f;//a
        Blue_Effect[4] = 1.0f;//g
        Blue_Effect[5] = 1.0f;//e
    }
    //α値の初期値【エフェクト】
    void Alpha_Color_Effect()
    {
        Alpha_Effect[0] = 0.0f;//数字
        Alpha_Effect[1] = 0.0f;//s
        Alpha_Effect[2] = 0.0f;//t
        Alpha_Effect[3] = 0.0f;//a
        Alpha_Effect[4] = 0.0f;//g
        Alpha_Effect[5] = 0.0f;//e
    }
    //色の書式設定【エフェクト】
    void Color_Effect()
    {
        //赤の初期値
        //Red_Color_Effect();
        //緑の初期値
        //Green_Color_Effect();
        //青の初期値
        //Blue_Color_Effect();
        //α値の初期値
        Alpha_Color_Effect();
    }

    /// <summary>
    /// 反映
    /// </summary>
    //本体に反映
    void Body_Stage()
    {
        Stage_Body[0].color = new Color(Red_Body[0] / Color_MAX, Green_Body[0] / Color_MAX, Blue_Body[0] / Color_MAX, Alpha_Body[0]);//数字
        Stage_Body[1].color = new Color(Red_Body[1] / Color_MAX, Green_Body[1] / Color_MAX, Blue_Body[1] / Color_MAX, Alpha_Body[1]);//s
        Stage_Body[2].color = new Color(Red_Body[2] / Color_MAX, Green_Body[2] / Color_MAX, Blue_Body[2] / Color_MAX, Alpha_Body[2]);//t
        Stage_Body[3].color = new Color(Red_Body[3] / Color_MAX, Green_Body[3] / Color_MAX, Blue_Body[3] / Color_MAX, Alpha_Body[3]);//a
        Stage_Body[4].color = new Color(Red_Body[4] / Color_MAX, Green_Body[4] / Color_MAX, Blue_Body[4] / Color_MAX, Alpha_Body[4]);//g
        Stage_Body[5].color = new Color(Red_Body[5] / Color_MAX, Green_Body[5] / Color_MAX, Blue_Body[5] / Color_MAX, Alpha_Body[5]);//e
    }
    //輪郭に反映
    void Contour_Stage()
    {
        Stage_Contour[0].color = new Color(Red_Contour[0] / Color_MAX, Green_Contour[0] / Color_MAX, Blue_Contour[0] / Color_MAX, Alpha_Contour[0]);//数字
        Stage_Contour[1].color = new Color(Red_Contour[1] / Color_MAX, Green_Contour[1] / Color_MAX, Blue_Contour[1] / Color_MAX, Alpha_Contour[1]);//s
        Stage_Contour[2].color = new Color(Red_Contour[2] / Color_MAX, Green_Contour[2] / Color_MAX, Blue_Contour[2] / Color_MAX, Alpha_Contour[2]);//t
        Stage_Contour[3].color = new Color(Red_Contour[3] / Color_MAX, Green_Contour[3] / Color_MAX, Blue_Contour[3] / Color_MAX, Alpha_Contour[3]);//a
        Stage_Contour[4].color = new Color(Red_Contour[4] / Color_MAX, Green_Contour[4] / Color_MAX, Blue_Contour[4] / Color_MAX, Alpha_Contour[4]);//g
        Stage_Contour[5].color = new Color(Red_Contour[5] / Color_MAX, Green_Contour[5] / Color_MAX, Blue_Contour[5] / Color_MAX, Alpha_Contour[5]);//e
    }
    //エフェクトに反映
    void Effect_Stage()
    {
        Stage_Effect[0].color = new Color(Red_Effect[0] / Color_MAX, Green_Effect[0] / Color_MAX, Blue_Effect[0] / Color_MAX, Alpha_Effect[0]);//数字
        Stage_Effect[1].color = new Color(Red_Effect[1] / Color_MAX, Green_Effect[1] / Color_MAX, Blue_Effect[1] / Color_MAX, Alpha_Effect[1]);//s
        Stage_Effect[2].color = new Color(Red_Effect[2] / Color_MAX, Green_Effect[2] / Color_MAX, Blue_Effect[2] / Color_MAX, Alpha_Effect[2]);//t
        Stage_Effect[3].color = new Color(Red_Effect[3] / Color_MAX, Green_Effect[3] / Color_MAX, Blue_Effect[3] / Color_MAX, Alpha_Effect[3]);//a
        Stage_Effect[4].color = new Color(Red_Effect[4] / Color_MAX, Green_Effect[4] / Color_MAX, Blue_Effect[4] / Color_MAX, Alpha_Effect[4]);//g
        Stage_Effect[5].color = new Color(Red_Effect[5] / Color_MAX, Green_Effect[5] / Color_MAX, Blue_Effect[5] / Color_MAX, Alpha_Effect[5]);//e
    }
    
    //初期
    void Start()
    {
        //色の初期【母体】
        Color_Body();
        //反映【母体】
        Body_Stage();

        //色の初期【輪郭】
        Color_Contour();
        //反映【輪郭】
        Contour_Stage();

        //色の初期【エフェクト】
        Color_Effect();
        //反映【エフェクト】
        Effect_Stage();
    }


    void Update()
    {
        //点滅表示【母体】
        Blink_Body_Set();
        //点滅表示【輪郭】
        Blink_Contour_Set();
        //点滅表示【エフェクト】
        Blink_Effect_Set();

    }
    /// <summary>
    /// 点滅処理　【母体】
    /// </summary>
    //点滅表示【母体】
    void Blink_Body_Set()
    {
        //反映
        Body_Stage();
        //点滅【本体】【数字】
        Blink_Zero_Number();
        //点滅【本体】【S】
        Blink_One_Text();
        //点滅【本体】【T】
        Blink_Second_Text();
        //点滅【本体】【A】
        Blink_Third_Text();
        //点滅【本体】【G】
        Blink_Fourth_Text();
        //点滅【本体】【E】
        Blink_Fifth_Text();
    }
    //点滅【本体】【数字】
    void Blink_Zero_Number()
    {
        //trueなら
        if (Change_Body[0] == true)
        {
            //α値を下げる
            Alpha_Body[0] -= Blink_Body[0] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Body[0] < 0)
            {
                //α値を0
                Alpha_Body[0] = 0;
                //点滅切替
                Change_Body[0] = false;
            }
        }
        //falseなら
        if (Change_Body[0] == false)
        {
            //α値を上げる
            Alpha_Body[0] += Blink_Body[0] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Body[0] > 1)
            {
                //α値を1
                Alpha_Body[0] = 1;
                //点滅切替
                Change_Body[0] = true;
            }
        }
    }
    //点滅【本体】【S】
    void Blink_One_Text()
    {
        //trueなら
        if (Change_Body[1] == true)
        {
            //α値を下げる
            Alpha_Body[1] -= Blink_Body[1] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Body[1] < 0)
            {
                //α値を0
                Alpha_Body[1] = 0;
                //点滅切替
                Change_Body[1] = false;
            }
        }
        //falseなら
        if (Change_Body[1] == false)
        {
            //α値を上げる
            Alpha_Body[1] += Blink_Body[1] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Body[1] > 1)
            {
                //α値を1
                Alpha_Body[1] = 1;
                //点滅切替
                Change_Body[1] = true;
            }
        }
    }
    //点滅【本体】【T】
    void Blink_Second_Text()
    {
        //trueなら
        if (Change_Body[2] == true)
        {
            //α値を下げる
            Alpha_Body[2] -= Blink_Body[2] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Body[2] < 0)
            {
                //α値を0
                Alpha_Body[2] = 0;
                //点滅切替
                Change_Body[2] = false;
            }
        }
        //falseなら
        if (Change_Body[2] == false)
        {
            //α値を上げる
            Alpha_Body[2] += Blink_Body[2] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Body[2] > 1)
            {
                //α値を1
                Alpha_Body[2] = 1;
                //点滅切替
                Change_Body[2] = true;
            }
        }
    }
    //点滅【本体】【A】
    void Blink_Third_Text()
    {
        //trueなら
        if (Change_Body[3] == true)
        {
            //α値を下げる
            Alpha_Body[3] -= Blink_Body[3] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Body[3] < 0)
            {
                //α値を0
                Alpha_Body[3] = 0;
                //点滅切替
                Change_Body[3] = false;
            }
        }
        //falseなら
        if (Change_Body[3] == false)
        {
            //α値を上げる
            Alpha_Body[3] += Blink_Body[3] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Body[3] > 1)
            {
                //α値を1
                Alpha_Body[3] = 1;
                //点滅切替
                Change_Body[3] = true;
            }
        }
    }
    //点滅【本体】【G】
    void Blink_Fourth_Text()
    {
        //trueなら
        if (Change_Body[4] == true)
        {
            //α値を下げる
            Alpha_Body[4] -= Blink_Body[4] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Body[4] < 0)
            {
                //α値を0
                Alpha_Body[4] = 0;
                //点滅切替
                Change_Body[4] = false;
            }
        }
        //falseなら
        if (Change_Body[4] == false)
        {
            //α値を上げる
            Alpha_Body[4] += Blink_Body[4] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Body[4] > 1)
            {
                //α値を1
                Alpha_Body[4] = 1;
                //点滅切替
                Change_Body[4] = true;
            }
        }
    }
    //点滅【本体】【E】
    void Blink_Fifth_Text()
    {
        //trueなら
        if (Change_Body[5] == true)
        {
            //α値を下げる
            Alpha_Body[5] -= Blink_Body[5] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Body[5] < 0)
            {
                //α値を0
                Alpha_Body[5] = 0;
                //点滅切替
                Change_Body[5] = false;
            }
        }
        //falseなら
        if (Change_Body[5] == false)
        {
            //α値を上げる
            Alpha_Body[5] += Blink_Body[5] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Body[5] > 1)
            {
                //α値を1
                Alpha_Body[5] = 1;
                //点滅切替
                Change_Body[5] = true;
            }
        }
    }

    /// <summary>
    /// 点滅処理【輪郭】
    /// </summary>
    //点滅【輪郭】
    void Blink_Contour_Set()
    {
        //反映【輪郭】
        Contour_Stage();
        //反映【輪郭】【数字】
        Blink_Contour_Zero_Number();
        //反映【輪郭】【S】
        Blink_Contour_One_Text();
        //反映【輪郭】【T】
        Blink_Contour_Second_Text();
        //反映【輪郭】【A】
        Blink_Contour_Third_Text();
        //反映【輪郭】【G】
        Blink_Contour_Forth_Text();
        //反映【輪郭】【E】
        Blink_Contour_Fifth_Text();
    }
    //点滅【輪郭】【数字】
    void Blink_Contour_Zero_Number()
    {
        //trueなら
        if (Change_Contour[0] == true)
        {
            //α値を下げる
            Alpha_Contour[0] -= Blink_Contour[0] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Contour[0] < 0)
            {
                //α値を0
                Alpha_Contour[0] = 0;
                //点滅切替
                Change_Contour[0] = false;
            }
        }
        //falseなら
        if (Change_Contour[0] == false)
        {
            //α値を上げる
            Alpha_Contour[0] += Blink_Contour[0] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Contour[0] > 1)
            {
                //α値を1
                Alpha_Contour[0] = 1;
                //点滅切替
                Change_Contour[0] = true;
            }
        }
    }
    //点滅【輪郭】【S】
    void Blink_Contour_One_Text()
    {
        //trueなら
        if (Change_Contour[1] == true)
        {
            //α値を下げる
            Alpha_Contour[1] -= Blink_Contour[1] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Contour[1] < 0)
            {
                //α値を0
                Alpha_Contour[1] = 0;
                //点滅切替
                Change_Contour[1] = false;
            }
        }
        //falseなら
        if (Change_Contour[1] == false)
        {
            //α値を上げる
            Alpha_Contour[1] += Blink_Contour[1] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Contour[1] > 1)
            {
                //α値を1
                Alpha_Contour[1] = 1;
                //点滅切替
                Change_Contour[1] = true;
            }
        }
    }
    //点滅【輪郭】【T】
    void Blink_Contour_Second_Text()
    {
        //trueなら
        if (Change_Contour[2] == true)
        {
            //α値を下げる
            Alpha_Contour[2] -= Blink_Contour[2] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Contour[2] < 0)
            {
                //α値を0
                Alpha_Contour[2] = 0;
                //点滅切替
                Change_Contour[2] = false;
            }
        }
        //falseなら
        if (Change_Contour[2] == false)
        {
            //α値を上げる
            Alpha_Contour[2] += Blink_Contour[2] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Contour[2] > 1)
            {
                //α値を1
                Alpha_Contour[2] = 1;
                //点滅切替
                Change_Contour[2] = true;
            }
        }
    }
    //点滅【輪郭】【A】
    void Blink_Contour_Third_Text()
    {
        //trueなら
        if (Change_Contour[3] == true)
        {
            //α値を下げる
            Alpha_Contour[3] -= Blink_Contour[3] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Contour[3] < 0)
            {
                //α値を0
                Alpha_Contour[3] = 0;
                //点滅切替
                Change_Contour[3] = false;
            }
        }
        //falseなら
        if (Change_Contour[3] == false)
        {
            //α値を上げる
            Alpha_Contour[3] += Blink_Contour[3] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Contour[3] > 1)
            {
                //α値を1
                Alpha_Contour[3] = 1;
                //点滅切替
                Change_Contour[3] = true;
            }
        }
    }
    //点滅【輪郭】【G】
    void Blink_Contour_Forth_Text()
    {
        //trueなら
        if (Change_Contour[4] == true)
        {
            //α値を下げる
            Alpha_Contour[4] -= Blink_Contour[4] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Contour[4] < 0)
            {
                //α値を0
                Alpha_Contour[4] = 0;
                //点滅切替
                Change_Contour[4] = false;
            }
        }
        //falseなら
        if (Change_Contour[4] == false)
        {
            //α値を上げる
            Alpha_Contour[4] += Blink_Contour[4] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Contour[4] > 1)
            {
                //α値を1
                Alpha_Contour[4] = 1;
                //点滅切替
                Change_Contour[4] = true;
            }
        }
    }
    //点滅【輪郭】【E】
    void Blink_Contour_Fifth_Text()
    {
        //trueなら
        if (Change_Contour[5] == true)
        {
            //α値を下げる
            Alpha_Contour[5] -= Blink_Contour[5] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Contour[5] < 0)
            {
                //α値を0
                Alpha_Contour[5] = 0;
                //点滅切替
                Change_Contour[5] = false;
            }
        }
        //falseなら
        if (Change_Contour[5] == false)
        {
            //α値を上げる
            Alpha_Contour[5] += Blink_Contour[5] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Contour[5] > 1)
            {
                //α値を1
                Alpha_Contour[5] = 1;
                //点滅切替
                Change_Contour[5] = true;
            }
        }
    }

    /// <summary>
    /// 点滅処理【エフェクト】
    /// </summary>
    //点滅【エフェクト】
    void Blink_Effect_Set()
    {
        //反映【エフェクト】
        Effect_Stage();
        //点滅【エフェクト】【数字】
        Blink_Effect_Zero_Number();
        //点滅【エフェクト】【S】
        Blink_Effect_One_Text();
        //点滅【エフェクト】【T】
        Blink_Effect_Second_Text();
        //点滅【エフェクト】【A】
        Blink_Effect_Third_Text();
        //点滅【エフェクト】【G】
        Blink_Effect_Fourth_Text();
        //点滅【エフェクト】【E】
        Blink_Effect_Fifth_Text();
    }
    //点滅【エフェクト】【数字】
    void Blink_Effect_Zero_Number()
    {
        //trueなら
        if (Change_Effect[0] == true)
        {
            //α値を下げる
            Alpha_Effect[0] -= Blink_Effect[0] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Effect[0] < 0)
            {
                //α値を0
                Alpha_Effect[0] = 0;
                //点滅切替
                Change_Effect[0] = false;
            }
        }
        //falseなら
        if (Change_Effect[0] == false)
        {
            //α値を上げる
            Alpha_Effect[0] += Blink_Effect[0] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Effect[0] > 1)
            {
                //α値を1
                Alpha_Effect[0] = 1;
                //点滅切替
                Change_Effect[0] = true;
            }
        }
    }
    //点滅【エフェクト】【S】
    void Blink_Effect_One_Text()
    {
        //trueなら
        if (Change_Effect[1] == true)
        {
            //α値を下げる
            Alpha_Effect[1] -= Blink_Effect[1] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Effect[1] < 0)
            {
                //α値を0
                Alpha_Effect[1] = 0;
                //点滅切替
                Change_Effect[1] = false;
            }
        }
        //falseなら
        if (Change_Effect[1] == false)
        {
            //α値を上げる
            Alpha_Effect[1] += Blink_Effect[1] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Effect[1] > 1)
            {
                //α値を1
                Alpha_Effect[1] = 1;
                //点滅切替
                Change_Effect[1] = true;
            }
        }
    }
    //点滅【エフェクト】【T】
    void Blink_Effect_Second_Text()
    {
        //trueなら
        if (Change_Effect[2] == true)
        {
            //α値を下げる
            Alpha_Effect[2] -= Blink_Effect[2] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Effect[2] < 0)
            {
                //α値を0
                Alpha_Effect[2] = 0;
                //点滅切替
                Change_Effect[2] = false;
            }
        }
        //falseなら
        if (Change_Effect[2] == false)
        {
            //α値を上げる
            Alpha_Effect[2] += Blink_Effect[2] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Effect[2] > 1)
            {
                //α値を1
                Alpha_Effect[2] = 1;
                //点滅切替
                Change_Effect[2] = true;
            }
        }
    }
    //点滅【エフェクト】【A】
    void Blink_Effect_Third_Text()
    {
        //trueなら
        if (Change_Effect[3] == true)
        {
            //α値を下げる
            Alpha_Effect[3] -= Blink_Effect[3] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Effect[3] < 0)
            {
                //α値を0
                Alpha_Effect[3] = 0;
                //点滅切替
                Change_Effect[3] = false;
            }
        }
        //falseなら
        if (Change_Effect[3] == false)
        {
            //α値を上げる
            Alpha_Effect[3] += Blink_Effect[3] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Effect[3] > 1)
            {
                //α値を1
                Alpha_Effect[3] = 1;
                //点滅切替
                Change_Effect[3] = true;
            }
        }
    }
    //点滅【エフェクト】【G】
    void Blink_Effect_Fourth_Text()
    {
        //trueなら
        if (Change_Effect[4] == true)
        {
            //α値を下げる
            Alpha_Effect[4] -= Blink_Effect[4] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Effect[4] < 0)
            {
                //α値を0
                Alpha_Effect[4] = 0;
                //点滅切替
                Change_Effect[4] = false;
            }
        }
        //falseなら
        if (Change_Effect[4] == false)
        {
            //α値を上げる
            Alpha_Effect[4] += Blink_Effect[4] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Effect[4] > 1)
            {
                //α値を1
                Alpha_Effect[4] = 1;
                //点滅切替
                Change_Effect[4] = true;
            }
        }
    }
    //点滅【エフェクト】【E】
    void Blink_Effect_Fifth_Text()
    {
        //trueなら
        if (Change_Effect[5] == true)
        {
            //α値を下げる
            Alpha_Effect[5] -= Blink_Effect[5] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha_Effect[5] < 0)
            {
                //α値を0
                Alpha_Effect[5] = 0;
                //点滅切替
                Change_Effect[5] = false;
            }
        }
        //falseなら
        if (Change_Effect[5] == false)
        {
            //α値を上げる
            Alpha_Effect[5] += Blink_Effect[5] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha_Effect[5] > 1)
            {
                //α値を1
                Alpha_Effect[5] = 1;
                //点滅切替
                Change_Effect[5] = true;
            }
        }
    }
}
