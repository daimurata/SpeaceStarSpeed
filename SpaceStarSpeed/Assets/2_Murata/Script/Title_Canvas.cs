using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// タイトルのSTART文字に使用
/// </summary>
public class Title_Canvas : MonoBehaviour
{
    //文字の母体
    public GameObject[] Text_Body = new GameObject[5];
    //文字の輪郭
    public GameObject[] Text_Contour = new GameObject[5];
    //文字のエフェクト
    public GameObject[] Text_Effect = new GameObject[5];

    //切替用
    public bool[] Change=new bool[3];

    //α値
    public float[]  Alpha = new float[3];
    //α値スピード
    public float[] Alpha_Speed = new float[3];

    //時間を計測
    public float Time_Count = 0.0f;

    //α値の設定
    void Alpha_Configuration()
    {
        //α値初期0表示
        Alpha[0] = 0.0f;//母体 01
        Alpha[1] = 0.0f;//輪郭 02
        Alpha[2] = 0.0f;//エフェクト 03

        /*
        //α値初期スピード
        Alpha_Speed[0] = 0.1f;//母体 01
        Alpha_Speed[1] = 0.2f;//輪郭 02
        Alpha_Speed[2] = 0.3f;//エフェクト 03
        */
    }

    //母体1グループ
    void Body_Set()
    {
        //START文字母体
        Text_Body[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//S
        Text_Body[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//T
        Text_Body[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//A
        Text_Body[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//R
        Text_Body[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//T2
    }
    //輪郭2グループ
    void Contour_Set()
    {
        //START文字輪郭
        Text_Contour[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//S
        Text_Contour[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//T
        Text_Contour[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//A
        Text_Contour[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//R
        Text_Contour[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//T2
    }
    //エフェクト3グループ
    void Effect_Set()
    {
        //START文字エフェクト
        Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//S
        Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//T
        Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//A
        Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//R
        Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//T2
    }

    //母体の非表示
   void Body_False()
    {
        //母体
        Text_Body[0].SetActive(false);//1
        Text_Body[1].SetActive(false);//2
        Text_Body[2].SetActive(false);//3
        Text_Body[3].SetActive(false);//4
        Text_Body[4].SetActive(false);//5
    }

    //母体の表示
    void Body_True()
    {
        //母体
        Text_Body[0].SetActive(true);//1
        Text_Body[1].SetActive(true);//2
        Text_Body[2].SetActive(true);//3
        Text_Body[3].SetActive(true);//4
        Text_Body[4].SetActive(true);//5
    }

    //輪郭の非表示
    void Contour_False()
    {
        //輪郭
        Text_Contour[0].SetActive(false);//11
        Text_Contour[1].SetActive(false);//2
        Text_Contour[2].SetActive(false);//3
        Text_Contour[3].SetActive(false);//4
        Text_Contour[4].SetActive(false);//5
    }

    //輪郭の表示
    void Contour_True()
    {
        //輪郭
        Text_Contour[0].SetActive(true);//11
        Text_Contour[1].SetActive(true);//2
        Text_Contour[2].SetActive(true);//3
        Text_Contour[3].SetActive(true);//4
        Text_Contour[4].SetActive(true);//5
    }

    //エフェクトの非表示
    void Effect_False()
    {
        //エフェクト
        Text_Effect[0].SetActive(false);//1
        Text_Effect[1].SetActive(false);//2
        Text_Effect[2].SetActive(false);//3
        Text_Effect[3].SetActive(false);//4
        Text_Effect[4].SetActive(false);//5
    }
    //エフェクトの表示
    void Effect_True()
    {
        //エフェクト
        Text_Effect[0].SetActive(true);//1
        Text_Effect[1].SetActive(true);//2
        Text_Effect[2].SetActive(true);//3
        Text_Effect[3].SetActive(true);//4
        Text_Effect[4].SetActive(true);//5
    }


    //初期設定
    void Start()
    {
        //α値の初期設定
        Alpha_Configuration();
        //母体の初期設定
        Body_Set();
        //輪郭の初期設定
        Contour_Set();
        //エフェクトの初期設定
        Effect_Set();

        //母体の非表示
        Body_False();
        //輪郭の非表示
        Contour_False();
        //エフェクトの非表示
        Effect_False();
    }

    //回す処理
    void Update()
    {
        //ゆっくり表示
        OLL_True();
        //スペースキーを押すと
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //文字スタート文字表示
            Change[0]=true;
        }

        //点滅処理

        if (Change[1] == true)
        {
            //エフェクト点滅
            Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//1
            Text_Effect[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//2
            Text_Effect[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//3
            Text_Effect[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//4
            Text_Effect[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//5
        }




    }
    //これを外部に渡せば使える
    public void Change_true()
    {
        //文字表示
        Change[0] = true;
    }

    //ゆっくリ表示
    void OLL_True()
    {
        //切替が表示
        if (Change[0] == true)
        {
            //輪郭を表示
            Contour_True();
            //α値に加算
            Alpha[1] += Alpha_Speed[1];
            //STARTの輪郭
            Text_Contour[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//1
            Text_Contour[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//2
            Text_Contour[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//3
            Text_Contour[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//4
            Text_Contour[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//5
            //輪郭のα値が100なら
            if (Alpha[1] >= 1.0f)
            {
                //加算をゼロ
                Alpha_Speed[1] = 0.0f;
                //α値の固定
                Alpha[1] = 1.0f;
            }
            //輪郭のα値が50以上なら
            if (Alpha[1] >= 0.5f)
            {
                //エフェクトを表示
                Effect_True();
                //α値に加算
                Alpha[2] += Alpha_Speed[2];
                //STARTのエフェクト
                Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//1
                Text_Effect[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//2
                Text_Effect[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//3
                Text_Effect[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//4
                Text_Effect[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//5
            }
            //α値が100なら
            if (Alpha[2] >= 1.0f)
            {
                //加算をゼロ
                Alpha_Speed[2] = 0.0f;
                //α値の固定
                Alpha[2] = 1.0f;
            }
            //エフェクトのα値が50以上なら
            if (Alpha[2] >= 0.5f)
            {
                //母体を表示
                Body_True();
                //α値に加算
                Alpha[0] += Alpha_Speed[0];
                //STARTの母体
                Text_Body[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//1
                Text_Body[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//2
                Text_Body[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//3
                Text_Body[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//4
                Text_Body[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//5
            }
            //α値が100なら
            if (Alpha[0] >= 1.0f)
            {
                //加算をゼロ
                Alpha_Speed[0] = 0.0f;
                //α値を固定
                Alpha[0] = 1.0f;

                //時間を加算
                Time_Count += Time.deltaTime;
                //3秒表示
                if (Time_Count>=3.0f)
                {
                    //3秒に固定
                    Time_Count = 3.0f;
                    //点滅処理開始
                    Change[1] = true;
                }
            }
        }
    }
}
