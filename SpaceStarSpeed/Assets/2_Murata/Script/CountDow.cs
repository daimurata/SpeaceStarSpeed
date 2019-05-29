using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// このスクリプトはゲーム開始時のスタートするカウントダウンです
/// </summary>
public class CountDow : MonoBehaviour
{
    //【親】カウントする数字とスタート開始文字
    public GameObject[] Count_Dow=new GameObject[4];

    //【子】Gの本体,Oの本体,1の本体,2の本体
    public GameObject[] Count_Zero1 = new GameObject[3], Count_Zero2 = new GameObject[3], Count_1 = new GameObject[3], Count_2 = new GameObject[3], Count_3 = new GameObject[3];

    //【子】1の星本体　12個,1の星輪郭　12個　
    public GameObject[] Star_1 = new GameObject[12], StarEF_1 = new GameObject[12];

    //【子】2の星本体　12個,2の星輪郭　12個　
    public GameObject[] Star_2 = new GameObject[12], StarEF_2 = new GameObject[12];

    //【子】3の星本体　12個,3の星輪郭　12個　
    public GameObject[] Star_3 = new GameObject[12], StarEF_3 = new GameObject[12];

    // カウント表示切替
    public bool Start_Change = false;

    //時間 星の回転スピード　角度
    public float Time_Count = 5.0f,Star_Speed,Angle;

    //GOの文字α値,1の文字α値,2の文字α値,3の文字α値
    public float[] Alpha_Zero = new float[3], Alpha_One = new float[3], Alpha_Second = new float[3], Alpha_Third = new float[3];

    //αのスピード
    public float Alpha_Speed = 0.01f;

    //赤文字
    public float[] Red_Zero, Red_One, Red_Second, Red_Third;
    //緑文字
    public float[] Green_Zero, Green_One, Green_Second, Green_Third;
    //青文字
    public float[] Blue_Zero, Blue_One, Blue_Second, Blue_Third;

    //赤星
    public float[] Red_One_Star, Red_Second_Star, Red_Third_Star;
    //緑星
    public float[] Green_One_Star, Green_Second_Star, Green_Third_Star;
    //青星1～3
    public float[] Blue_One_Star, Blue_Second_Star, Blue_Third_Star;
    //α値星1～3
    public float[] Alpha_One_Star, Alpha_Second_Star, Alpha_Third_Star;

    //EF RGB
    public float RED_EF, GREEN_EF, BLUE_EF;

    //数字【星数】、文字【テキスト】
    public int Number,Text;

    private int MAX = 255;
    /// <summary>
    /// 【文字】【非表示】
    /// </summary>
    //テキスト 非表示【テキスト全ての非表示】
    void Text_False()
    {
        //【GO】非表示
        Count_Dow[0].SetActive(false);
        //【1】非表示
        Count_Dow[1].SetActive(false);
        //【2】非表示
        Count_Dow[2].SetActive(false);
        //【3】非表示
        Count_Dow[3].SetActive(false);

        //【子】　GO非表示
        Text_Zero();
        //【子】　1非表示
        Text_One();
        //【子】　2非表示
        Text_Second();
        //【子】　3非表示
        Text_Third();
    }
    //GO　非表示【テキスト】
    void Text_Zero()
    {
        //G文字
        Count_Zero1[0].SetActive(false);//母体
        Count_Zero1[1].SetActive(false);//輪郭
        Count_Zero1[2].SetActive(false);//エフェクト

        //O文字
        Count_Zero2[0].SetActive(false);//母体
        Count_Zero2[1].SetActive(false);//輪郭
        Count_Zero2[2].SetActive(false);//エフェクト
    }
    //1 非表示【テキスト】
    void Text_One()
    {
        //1本体
        Count_1[0].SetActive(false);//母体
        Count_1[1].SetActive(false);//輪郭
        Count_1[2].SetActive(false);//エフェクト
    }
    //2　非表示【テキスト】
    void Text_Second()
    {
        //2本体
        Count_2[0].SetActive(false);//母体
        Count_2[1].SetActive(false);//輪郭
        Count_2[2].SetActive(false);//エフェクト
    }
    //3　非表示【テキスト】
    void Text_Third()
    {
        //3本体
        Count_3[0].SetActive(false);//母体
        Count_3[1].SetActive(false);//輪郭
        Count_3[2].SetActive(false);//エフェクト
    }

    /// <summary>
    /// 【星】【非表示】
    /// </summary>
    //【1星】本体　非表示
    void Star_One()
    {
        //星1～12
        for (int i=0;i<Number;++i)
        {
            Star_1[i].SetActive(false);//星
        }
        return;//繰り返す
    }
    //【1星】輪郭　非表示
    void StarEF_One()
    {
        //輪郭1～12
        for (int i=0;i<Number;++i)
        {
            StarEF_1[i].SetActive(false);//輪郭
        }
        return;//繰り返す
    }
    //【2星】本体　非表示
    void Star_Second()
    {
        //星1～12
        for (int i=0;i<Number;++i)
        {
            Star_2[i].SetActive(false);//星
        }
        return;//繰り返す
    }
    //【2星】輪郭　非表示
    void StarEF_Second()
    {
        //輪郭1～12
        for (int i=0;i<Number;++i)
        {
            StarEF_2[i].SetActive(false);//星
        }
        return;//繰り返す
    }
    //【3星】本体　非表示
    void Star_Third()
    {
        //星1～12
        for (int i=0;i<Number;++i)
        {
            Star_3[i].SetActive(false);//星
        }
        return;//繰り返す
    }
    //【3星】輪郭　非表示
    void StarEF_Third()
    {
        //輪郭1～12
        for (int i=0;i<Number;++i)
        {
            StarEF_3[i].SetActive(false);//輪郭
        }
        return;//繰り返す
    }
    //星　非表示【星全て非表示】
    void Stars_False()
    {
        //【1星】【本体】非表示
        Star_One();
        //【1星】【輪郭】非表示
        StarEF_One();
        //【2星】【本体】非表示
        Star_Second();
        //【2星】【輪郭】非表示
        StarEF_Second();
        //【3星】【本体】非表示
        Star_Third();
        //【3星】【輪郭】非表示
        StarEF_Third();
    }

    /// <summary>
    /// 【α値設定】【星＆文字】
    /// </summary>
    //文字のα値をゼロ【テキスト】
    void Text_a()
    {
        //Textの数やる
        for (int i=0;i<Text;++i)
        {
            Alpha_Zero[i] = 0.0f;
            //Gの本体,輪郭,エフェクト,α値
            Count_Zero1[i].GetComponent<Image>().color = new Color(Red_Zero[i]/MAX, Green_Zero[i] / MAX, Blue_Zero[i] / MAX, Alpha_Zero[i]);
            //Oの本体,輪郭,エフェクト,α値
            Count_Zero2[i].GetComponent<Image>().color = new Color(Red_Zero[i] / MAX, Green_Zero[i] / MAX, Blue_Zero[i] / MAX, Alpha_Zero[i]);
            //1の本体,輪郭,エフェクト,α値
            Count_1[i].GetComponent<Image>().color = new Color(Red_One[i] / MAX, Green_One[i] / MAX, Blue_One[i] / MAX, Alpha_One[i]);
            //2の本体,輪郭,エフェクト,α値
            Count_2[i].GetComponent<Image>().color = new Color(Red_Second[i] / MAX, Green_Second[i] / MAX, Blue_Second[i] / MAX, Alpha_Second[i]);
            //3の本体,輪郭,エフェクト,α値
            Count_3[i].GetComponent<Image>().color = new Color(Red_Third[i] / MAX, Green_Third[i] / MAX, Blue_Third[i] / MAX, Alpha_Third[i]);
        }
        return;//繰り返す
    }

    //1星の本体α値をゼロ【星1の設定】
    void OneStar_a()
    {
        //星1～12本体
        for (int i=0;i<Number;++i)
        {
            Star_1[i].GetComponent<Image>().color = new Color(Red_One_Star[i] / MAX, Green_One_Star[i] / MAX, Blue_One_Star[i] / MAX, Alpha_One_Star[i]);
        }
        return;//繰り返す
    }
    //1星のEFα値をゼロ【星1エフェクトの設定】
    void OneStarEF_a()
    {
        //星1～12本体
        for (int i=0;i<Number;++i)
        {
            StarEF_1[i].GetComponent<Image>().color = new Color(RED_EF / MAX, GREEN_EF / MAX, BLUE_EF / MAX, Alpha_One_Star[i]);//星
        }
        return;//繰り返す
    }
    //2星の本体α値をゼロ【星2の設定】
    void SecondStar_a()
    {
        //星1～12本体
        for (int i=0;i<Number;++i)
        {
            Star_2[i].GetComponent<Image>().color = new Color(Red_Second_Star[i] / MAX, Green_Second_Star[i] / MAX, Blue_Second_Star[i] / MAX, Alpha_Second_Star[i]);//星
        }
        return;//繰り返す
    }
    //2星のEFα値をゼロ【星2エフェクトの設定】
    void SecondStarEF_a()
    {
        //星1～12本体
        for (int i=0;i<Number;++i)
        {
            StarEF_2[i].GetComponent<Image>().color = new Color(RED_EF / MAX, GREEN_EF / MAX, BLUE_EF / MAX, Alpha_Second_Star[i]);//星
        }
        return;//繰り返す
    }
    //3星の本体α値をゼロ【星3の設定】
    void ThirdStar_a()
    {
        //星1～12本体
        for(int i=0;i<Number;++i)
        {
            Star_3[i].GetComponent<Image>().color = new Color(Red_Third_Star[i] / MAX, Green_Third_Star[i] / MAX, Blue_Third_Star[i] / MAX, Alpha_Third_Star[i]);//星
        }
        return;//繰り返す
    }
    //3星のEFα値をゼロ【星3エフェクトの設定】
    void ThirdStarEF_a()
    {
        //星1～12本体
        for (int i=0;i<Number;++i)
        {
            StarEF_3[i].GetComponent<Image>().color = new Color(RED_EF / MAX, GREEN_EF / MAX, BLUE_EF / MAX, Alpha_Third_Star[i]);
        }
    }

    /// <summary>
    /// 【星のα値まとめ】
    /// </summary>
    //星のα値集合体【星全ての初期設定】
    void Star_a()
    {
        //星1本体
        OneStar_a();
        //星1エフェクト
        OneStarEF_a();
        //星2本体
        SecondStar_a();
        //星2エフェクト
        SecondStarEF_a();
        //星3本体
        ThirdStar_a();
        //星3エフェクト
        ThirdStarEF_a();
    }

    //初期スタート設定
    void Start()
    {
        //テキスト 非表示
        Text_False();
        //テキスト　α値　ゼロ
        Text_a();

        //星　非表示
        Stars_False();
        //星　α値　ゼロ
        Star_a();
    }

    //回し続ける
    void Update()
    {
        //Trueなら
        if (Start_Change==true)
        {
            //カウントダウン開始
            Count_Dow_Start();
        }
        //キー入力
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //カウントダウン起動
            Start_Change = true;
        }
        //Numberの数やる
        for (int i=0;i<Number;++i)
        {
            Star_1[i].transform.Rotate(new Vector3(0, 0, Angle) * Star_Speed * Time.deltaTime);//星1の図形
            StarEF_1[i].transform.Rotate(new Vector3(0, 0, Angle) * Star_Speed * Time.deltaTime);//星1のエフェクト
            Star_2[i].transform.Rotate(new Vector3(0, 0, Angle) * Star_Speed * Time.deltaTime);//星2の図形
            StarEF_2[i].transform.Rotate(new Vector3(0, 0, Angle) * Star_Speed * Time.deltaTime);//星2のエフェクト
            Star_3[i].transform.Rotate(new Vector3(0, 0, Angle) * Star_Speed * Time.deltaTime);//星3の図形
            StarEF_3[i].transform.Rotate(new Vector3(0, 0, Angle) * Star_Speed * Time.deltaTime);//星3のエフェクト
        } return;
    }
    /// <summary>
    /// 【外部】
    /// </summary>
    //外部で起動させる時
    public void Change_true()
    {
        //カウントダウン起動
        Start_Change = true;
    } 
    /// <summary>
    /// 【文字】【処理】
    /// </summary>
    //時間経過処理【文字】
    void Count_Dow_Start()
    {
        //時間経過
        Time_Count -= 0.01f;

        //3の文字表示開始
        if (Time_Count <= 5.0f)
        {
            //3の文字親表示
            Count_Dow[3].SetActive(true);
            //2の文字親表示
            Count_Dow[2].SetActive(true);
            //準備
            Star_Stat_Setting();

            //α値加算
            Alpha_Third[1] += Alpha_Speed;
            //3の星アニメーション
            Star_Third_true();

            //文字表示時間
            if (Time_Count <= 3.5f)
            {
                //2の文字親表示
               // Count_Dow[2].SetActive(true);

                //3の母体表示
                Count_3[0].SetActive(true);
                //α値加算
                Alpha_Third[0] += Alpha_Speed;
                //3の母体α値100％
                Count_3[0].GetComponent<Image>().color = new Color(Red_Third[0] / MAX, Green_Third[0] / MAX, Blue_Third[0] / MAX, Alpha_Third[0]);
            }

            //3の輪郭表示
            Count_3[1].SetActive(true);
            //3の輪郭α値100％
            Count_3[1].GetComponent<Image>().color = new Color(Red_Third[1] / MAX, Green_Third[1] / MAX, Blue_Third[1] / MAX, Alpha_Third[1]);
            //3の文字エフェクト表示時間
            if (Time_Count <= 3.8f)
            {
                //3のエフェクト表示
                Count_3[2].SetActive(true);
                //α値加算
                Alpha_Third[2] += Alpha_Speed;
                //3のエフェクトα値100％
                Count_3[2].GetComponent<Image>().color = new Color(Red_Third[2] / MAX, Green_Third[2] / MAX, Blue_Third[2] / MAX, Alpha_Third[2]);
            }
        }
        //3秒以下なら2の文字表示【文字】
        if (Time_Count <= 3.0f)
        {
            //1の文字親表示
            Count_Dow[1].SetActive(true);
            //3の文字親非表示
            Count_3[0].SetActive(false);
            //3の文字母体非表示
            Count_3[1].SetActive(false);
            //3の文字輪郭非表示
            Count_3[2].SetActive(false);
            //3の文字エフェクト非表示
            Count_Dow[3].SetActive(false);
            Alpha_Third[0] = 0.0f;//終了固定
            Alpha_Third[1] = 0.0f;//終了固定
            Alpha_Third[2] = 0.0f;//終了固定

            //2の文字親表示
            //Count_Dow[2].SetActive(true);
            Alpha_Second[1] += Alpha_Speed;

            //2星のアニメーション
            Star_Second_true();

            //文字表示時間
            if (Time_Count <= 2.5f)
            {
                //1の文字親表示
                //Count_Dow[1].SetActive(true);

                //2の文字母体表示
                Count_2[0].SetActive(true);
                //α値加算
                Alpha_Second[0] += Alpha_Speed;
                //2の文字母体α値100％
                Count_2[0].GetComponent<Image>().color = new Color(Red_Second[0] / MAX, Green_Second[0] / MAX, Blue_Second[0] / MAX, Alpha_Second[0]);
            }

            //2の文字輪郭表示
            Count_2[1].SetActive(true);
            //2の文字輪郭α値100％
            Count_2[1].GetComponent<Image>().color = new Color(Red_Second[1] / MAX, Green_Second[1] / MAX, Blue_Second[1] / MAX, Alpha_Second[1]);

            //2の文字エフェクト表示時間
            if (Time_Count <= 2.8f)
            {
                //2の文字エフェクト表示
                Count_2[2].SetActive(true);
                //α値加算
                Alpha_Second[2] += Alpha_Speed;
                //2の文字エフェクトα値100％
                Count_2[2].GetComponent<Image>().color = new Color(Red_Second[2] / MAX, Green_Second[2] / MAX, Blue_Second[2] / MAX, Alpha_Second[2]);
            }
        }
        //2秒以下なら1の文字表示【文字】
        if (Time_Count <= 2.0f)
        {
            //2の文字親非表示
            Count_2[0].SetActive(false);
            //2の文字母体非表示
            Count_2[1].SetActive(false);
            //2の文字輪郭非表示
            Count_2[2].SetActive(false);
            //2の文字エフェクト非表示
            Count_Dow[2].SetActive(false);
            Alpha_Second[0] = 0.0f;//終了固定
            Alpha_Second[1] = 0.0f;//終了固定
            Alpha_Second[2] = 0.0f;//終了固定

            //1の文字親表示
            //Count_Dow[1].SetActive(true);
            //α値加算
            Alpha_One[1] += Alpha_Speed;

            //1の星アニメーション
            Star_One_true();

            //文字表示時間
            if (Time_Count <= 1.5f)
            {
                //1の文字母体表示
                Count_1[0].SetActive(true);
                //α値加算
                Alpha_One[0] += Alpha_Speed;
                //1の文字母体α値100％
                Count_1[0].GetComponent<Image>().color = new Color(Red_One[0] / MAX, Green_One[0] / MAX, Blue_One[0] / MAX, Alpha_One[0]);
            }

            //1の文字輪郭表示
            Count_1[1].SetActive(true);
            //1の文字輪郭α値100％
            Count_1[1].GetComponent<Image>().color = new Color(Red_One[1] / MAX, Green_One[1] / MAX, Blue_One[1] / MAX, Alpha_One[1]);
            //1の文字エフェクト表示時間
            if (Time_Count <= 1.8f)
            {
                //1の文字エフェクト表示
                Count_1[2].SetActive(true);
                //α値加算
                Alpha_One[2] += Alpha_Speed;
                //1の文字エフェクト表示α値100％
                Count_1[2].GetComponent<Image>().color = new Color(Red_One[2] / MAX, Green_One[2] / MAX, Blue_One[2] / MAX, Alpha_One[2]);
            }
        }
        //1秒以下ならGOの文字表示【文字】
        if (Time_Count <= 1.0f)
        {
            //1の文字親非表示
            Count_1[0].SetActive(false);
            //1の文字母体非表示
            Count_1[1].SetActive(false);
            //1の文字輪郭非表示
            Count_1[2].SetActive(false);
            //1の文字エフェクト非表示
            Count_Dow[1].SetActive(false);
            Alpha_One[0] = 0.0f;//終了固定
            Alpha_One[1] = 0.0f;//終了固定
            Alpha_One[2] = 0.0f;//終了固定

            //GOの文字親表示【文字】
            Count_Dow[0].SetActive(true);
            //α値加算
            Alpha_Zero[1] += Alpha_Speed;
            //文字表示時間
            if (Time_Count <= 0.7f)
            {
                //Gの文字母体表示
                Count_Zero1[0].SetActive(true);
                //α値加算
                Alpha_Zero[0] += Alpha_Speed;
                //Gの文字母体α値100％
                Count_Zero1[0].GetComponent<Image>().color = new Color(Red_Zero[0] / MAX, Green_Zero[0] / MAX, Blue_Zero[0] / MAX, Alpha_Zero[0]);

                //Oの文字母体表示
                Count_Zero2[0].SetActive(true);
                //Oの文字母体α値100％
                Count_Zero2[0].GetComponent<Image>().color = new Color(Red_Zero[0] / MAX, Green_Zero[0] / MAX, Blue_Zero[0] / MAX, Alpha_Zero[0]);
            }

            //Gの文字輪郭表示
            Count_Zero1[1].SetActive(true);
            //Gの文字輪郭α値100％
            Count_Zero1[1].GetComponent<Image>().color = new Color(Red_Zero[1] / MAX, Green_Zero[1] / MAX, Blue_Zero[1] / MAX, Alpha_Zero[1]);

            //Oの文字輪郭表示
            Count_Zero2[1].SetActive(true);
            //Oの文字輪郭α値100％
            Count_Zero2[1].GetComponent<Image>().color = new Color(Red_Zero[1] / MAX, Green_Zero[1] / MAX, Blue_Zero[1] / MAX, Alpha_Zero[1]);

            //GOの文字表示時間
            if (Time_Count <= 0.8f)
            {
                //Gの文字エフェクト表示
                Count_Zero1[2].SetActive(true);
                //α値加算
                Alpha_Zero[2] += Alpha_Speed;
                //Gの文字エフェクトα値100％
                Count_Zero1[2].GetComponent<Image>().color = new Color(Red_Zero[2] / MAX, Green_Zero[2] / MAX, Blue_Zero[2] / MAX, Alpha_Zero[2]);

                //Oの文字エフェクト表示
                Count_Zero2[2].SetActive(true);
                //Oの文字エフェクトα値100％
                Count_Zero2[2].GetComponent<Image>().color = new Color(Red_Zero[2] / MAX, Green_Zero[2] / MAX, Blue_Zero[2] / MAX, Alpha_Zero[2]);
            }
        }
        //0秒以下になったら全て非表示
        if (Time_Count <= 0.0f)
        {
            //GOの文字親非表示
            Count_Dow[0].SetActive(false);

            //時間はマイナス表示
            Time_Count = -1.0f;//終了固定
            Alpha_Zero[0] = 0.0f;//終了固定
            Alpha_Zero[1] = 0.0f;//終了固定
            Alpha_Zero[2] = 0.0f;//終了固定
            Alpha_Speed = 0.0f;//終了固定

            //役割終了
            Start_Change =false;
        }
    }

    /// <summary>
    /// 【星カウントダウン準備】【エフェクト】
    /// </summary>
    //エフェクト配置3星
    void Star_Stat_Setting()
    {

        //表示する時間
        if (Time_Count<=4.88f)
        {
            StarEF_3[0].SetActive(true);//3星1
        }
        //表示する時間
        if (Time_Count <= 4.8f)
        {
            StarEF_3[1].SetActive(true);//3星2
        }
        //表示する時間
        if (Time_Count <= 4.72f)
        {
            StarEF_3[2].SetActive(true);//3星3
        }
        //表示する時間
        if (Time_Count <= 4.64f)
        {
            StarEF_3[3].SetActive(true);//3星4
        }
        //表示する時間
        if (Time_Count <= 4.56f)
        {
            StarEF_3[4].SetActive(true);//3星5
        }
        //表示する時間
        if (Time_Count <= 4.48f)
        {
            StarEF_3[5].SetActive(true);//3星6
        }
        //表示する時間
        if (Time_Count <= 4.4f)
        {
            StarEF_3[6].SetActive(true);//3星7
        }
        //表示する時間
        if (Time_Count <= 4.32f)
        {
            StarEF_3[7].SetActive(true);//3星8
        }
        //表示する時間
        if (Time_Count <= 4.24f)
        {
            StarEF_3[8].SetActive(true);//3星9
        }
        //表示する時間
        if (Time_Count <= 4.16f)
        {
            StarEF_3[9].SetActive(true);//3星10
        }
        //表示する時間
        if (Time_Count <= 4.08f)
        {
            StarEF_3[10].SetActive(true);//3星11
        }
        //表示する時間
        if (Time_Count <= 4f)
        {
            StarEF_3[11].SetActive(true);//3星12
        }
        //色の設定
        StarEF_Third_EF_True();
    }

    /// <summary>
    /// 【3星カウントダウン】【エフェクト】
    /// </summary>
    //反映ループ処理【エフェクト】
    void StarEF_Third_EF_True()
    {
        //星エフェクト1表示
        for (int i = 0; i < Number; ++i)
        {
            Alpha_One_Star[i] = 1.0f;//α値表示
            //StarEF_3[i].SetActive(true);//表示【エフェクト】
            StarEF_3[i].GetComponent<Image>().color = new Color(RED_EF / MAX, GREEN_EF / MAX, BLUE_EF / MAX, Alpha_Third_Star[i]);//α表示
        }return;//繰り返す
    }

    /// <summary>
    /// 【3星カウントダウン】【本体】
    /// </summary>
    //星3表示アニメーションもどき【星】
    void Star_Third_true()
    {
        //反映【全部出す】
        //StarEF_Third_EF_True();
        //星1表示
        if (Time_Count<=3.92f)
        {
            //星本体1表示
            Star_3[0].SetActive(true);
            Star_3[0].GetComponent<Image>().color = new Color(Red_Third_Star[0] / MAX, Green_Third_Star[0] / MAX, Blue_Third_Star[0] / MAX, Alpha_Third_Star[0]);//α表示
        }
        //星2表示
        if (Time_Count<=3.84f)
        {
            //星本体2表示
            Star_3[1].SetActive(true);
            Star_3[1].GetComponent<Image>().color = new Color(Red_Third_Star[1] / MAX, Green_Third_Star[1] / MAX, Blue_Third_Star[1] / MAX, Alpha_Third_Star[1]);//α表示
            //星本体1非表示
            Star_3[0].SetActive(false);
            //星エフェクト1非表示
            StarEF_3[0].SetActive(false);

            //2星1を表示
            StarEF_2[0].SetActive(true);
        }
        //星3表示
        if (Time_Count<=3.76f)
        {
            //星本体3表示
            Star_3[2].SetActive(true);
            Star_3[2].GetComponent<Image>().color = new Color(Red_Third_Star[2] / MAX, Green_Third_Star[2] / MAX, Blue_Third_Star[2] / MAX, Alpha_Third_Star[2]);//α表示
            //星本体2非表示
            Star_3[1].SetActive(false);
            //星エフェクト2非表示
            StarEF_3[1].SetActive(false);

            //2星2を表示
            StarEF_2[1].SetActive(true);
        }
        //星4表示
        if (Time_Count <= 3.68f)
        {
            //星本体4表示
            Star_3[3].SetActive(true);
            Star_3[3].GetComponent<Image>().color = new Color(Red_Third_Star[3] / MAX, Green_Third_Star[3] / MAX, Blue_Third_Star[3] / MAX, Alpha_Third_Star[3]);//α表示
            //星本体3非表示
            Star_3[2].SetActive(false);
            //星エフェクト3非表示
            StarEF_3[2].SetActive(false);

            //2星3を表示
            StarEF_2[2].SetActive(true);
        }
        //星5表示
        if (Time_Count <= 3.6f)
        {
            //星本体5表示
            Star_3[4].SetActive(true);
            Star_3[4].GetComponent<Image>().color = new Color(Red_Third_Star[4] / MAX, Green_Third_Star[4] / MAX, Blue_Third_Star[4] / MAX, Alpha_Third_Star[4]);//α表示
            //星本体4非表示
            Star_3[3].SetActive(false);
            //星エフェクト4非表示
            StarEF_3[3].SetActive(false);

            //2星4を表示
            StarEF_2[3].SetActive(true);
        }
        //星6表示
        if (Time_Count <= 3.52f)
        {
            //星本体6表示
            Star_3[5].SetActive(true);
            Star_3[5].GetComponent<Image>().color = new Color(Red_Third_Star[5] / MAX, Green_Third_Star[5] / MAX, Blue_Third_Star[5] / MAX, Alpha_Third_Star[5]);//α表示
            //星本体5非表示
            Star_3[4].SetActive(false);
            //星エフェクト5非表示
            StarEF_3[4].SetActive(false);

            //2星5を表示
            StarEF_2[4].SetActive(true);
        }
        //星7表示
        if (Time_Count<=3.44f)
        {
            //星本体7表示
            Star_3[6].SetActive(true);
            Star_3[6].GetComponent<Image>().color = new Color(Red_Third_Star[6] / MAX, Green_Third_Star[6] / MAX, Blue_Third_Star[6] / MAX, Alpha_Third_Star[6]);//α表示
            //星本体6非表示
            Star_3[5].SetActive(false);
            //星エフェクト6非表示
            StarEF_3[5].SetActive(false);

            //2星6を表示
            StarEF_2[5].SetActive(true);
        }
        //星8表示
        if (Time_Count<=3.36f)
        {
            //星本体8表示
            Star_3[7].SetActive(true);
            Star_3[7].GetComponent<Image>().color = new Color(Red_Third_Star[7] / MAX, Green_Third_Star[7] / MAX, Blue_Third_Star[7] / MAX, Alpha_Third_Star[7]);//α表示
            //星本体7非表示
            Star_3[6].SetActive(false);
            //星エフェクト7非表示
            StarEF_3[6].SetActive(false);

            //2星7を表示
            StarEF_2[6].SetActive(true);
        }
        //星9表示
        if (Time_Count <= 3.28f)
        {
            //星本体9表示
            Star_3[8].SetActive(true);
            Star_3[8].GetComponent<Image>().color = new Color(Red_Third_Star[8] / MAX, Green_Third_Star[8] / MAX, Blue_Third_Star[8] / MAX, Alpha_Third_Star[8]);//α表示
            //星本体8非表示
            Star_3[7].SetActive(false);
            //星エフェクト8非表示
            StarEF_3[7].SetActive(false);

            //2星8を表示
            StarEF_2[7].SetActive(true);
        }
        //星10表示
        if (Time_Count<=3.2f)
        {
            //星本体10表示
            Star_3[9].SetActive(true);
            Star_3[9].GetComponent<Image>().color = new Color(Red_Third_Star[9] / MAX, Green_Third_Star[9] / MAX, Blue_Third_Star[9] / MAX, Alpha_Third_Star[9]);//α表示
            //星本体9非表示
            Star_3[8].SetActive(false);
            //星エフェクト9非表示
            StarEF_3[8].SetActive(false);

            //2星9を表示
            StarEF_2[8].SetActive(true);
        }
        //星11表示
        if (Time_Count<=3.12f)
        {
            //星本体11表示
            Star_3[10].SetActive(true);
            Star_3[10].GetComponent<Image>().color = new Color(Red_Third_Star[10] / MAX, Green_Third_Star[10] / MAX, Blue_Third_Star[10] / MAX, Alpha_Third_Star[10]);//α表示
            //星本体10非表示
            Star_3[9].SetActive(false);
            //星エフェクト10非表示
            StarEF_3[9].SetActive(false);

            //2星10を表示
            StarEF_2[9].SetActive(true);
        }
        //星12表示
        if (Time_Count<=3.04f)
        {
            //星本体12表示
            Star_3[11].SetActive(true);
            Star_3[11].GetComponent<Image>().color = new Color(Red_Third_Star[11] / MAX, Green_Third_Star[11] / MAX, Blue_Third_Star[11] / MAX, Alpha_Third_Star[11]);//α表示
            //星本体11非表示
            Star_3[10].SetActive(false);
            //星エフェクト11非表示
            StarEF_3[10].SetActive(false);

            //2星11を表示
            StarEF_2[10].SetActive(true);
        }
        //星非表示
        if (Time_Count <= 3f)
        {
            //星本体12非表示
            Star_3[11].SetActive(false);
            //星エフェクト12非表示
            StarEF_3[11].SetActive(false);
        }
    }

    /// <summary>
    /// 【2星カウントダウン】【エフェクト】
    /// </summary>
    //反映ループ処理
    void StarEF_Second_EF_True()
    {
        //numberの数だけ
        for (int i=0;i<Number;++i)
        {
            //α値の値固定
            Alpha_Second_Star[i]=1.0f;
            //星エフェクト1表示
            //StarEF_2[i].SetActive(true);
            StarEF_2[i].GetComponent<Image>().color = new Color(RED_EF / MAX, GREEN_EF / MAX, BLUE_EF / MAX, Alpha_Second_Star[i]);//α表示
        }
        return;//繰り返す
    }

    /// <summary>
    /// 【2星カウントダウン】【本体】
    /// </summary>
    //星2表示アニメーションもどき
    void Star_Second_true()
    {
        //反映
        StarEF_Second_EF_True();

        //星1表示
        if (Time_Count <= 2.92f)
        {
            //2星12を表示
            StarEF_2[11].SetActive(true);

            //星本体1表示
            Star_2[0].SetActive(true);
            Star_2[0].GetComponent<Image>().color = new Color(Red_Second_Star[0] / MAX, Green_Second_Star[0] / MAX, Blue_Second_Star[0] / MAX, Alpha_Second_Star[0]);//α表示
        }
        //星2表示
        if (Time_Count <= 2.84f)
        {
            //1星1を表示
            StarEF_1[0].SetActive(true);

            //星本体2表示
            Star_2[1].SetActive(true);
            Star_2[1].GetComponent<Image>().color = new Color(Red_Second_Star[1] / MAX, Green_Second_Star[1] / MAX, Blue_Second_Star[1] / MAX, Alpha_Second_Star[1]);//α表示
            //星本体1非表示
            Star_2[0].SetActive(false);
            //星エフェクト1非表示
            StarEF_2[0].SetActive(false);
        }
        //星3表示
        if (Time_Count <= 2.76f)
        {
            //1星2を表示
            StarEF_1[1].SetActive(true);

            //星本体3表示
            Star_2[2].SetActive(true);
            Star_2[2].GetComponent<Image>().color = new Color(Red_Second_Star[2] / MAX, Green_Second_Star[2] / MAX, Blue_Second_Star[2] / MAX, Alpha_Second_Star[2]);//α表示
            //星本体2非表示
            Star_2[1].SetActive(false);
            //星エフェクト2非表示
            StarEF_2[1].SetActive(false);
        }
        //星4表示
        if (Time_Count <= 2.68f)
        {
            //1星3を表示
            StarEF_1[2].SetActive(true);

            //星本体4表示
            Star_2[3].SetActive(true);
            Star_2[3].GetComponent<Image>().color = new Color(Red_Second_Star[3] / MAX, Green_Second_Star[3] / MAX, Blue_Second_Star[3] / MAX, Alpha_Second_Star[3]);//α表示
            //星本体3非表示
            Star_2[2].SetActive(false);
            //星エフェクト3非表示
            StarEF_2[2].SetActive(false);
        }
        //星5表示
        if (Time_Count <= 2.6f)
        {
            //1星4を表示
            StarEF_1[3].SetActive(true);

            //星本体5表示
            Star_2[4].SetActive(true);
            Star_2[4].GetComponent<Image>().color = new Color(Red_Second_Star[4] / MAX, Green_Second_Star[4] / MAX, Blue_Second_Star[4] / MAX, Alpha_Second_Star[4]);//α表示
            //星本体4非表示
            Star_2[3].SetActive(false);
            //星エフェクト4非表示
            StarEF_2[3].SetActive(false);
        }
        //星6表示
        if (Time_Count <= 2.52f)
        {
            //1星5を表示
            StarEF_1[4].SetActive(true);

            //星本体6表示
            Star_2[5].SetActive(true);
            Star_2[5].GetComponent<Image>().color = new Color(Red_Second_Star[5] / MAX, Green_Second_Star[5] / MAX, Blue_Second_Star[5] / MAX, Alpha_Second_Star[5]);//α表示
            //星本体5非表示
            Star_2[4].SetActive(false);
            //星エフェクト5非表示
            StarEF_2[4].SetActive(false);
        }
        //星7表示
        if (Time_Count <= 2.44f)
        {
            //1星6を表示
            StarEF_1[5].SetActive(true);

            //星本体7表示
            Star_2[6].SetActive(true);
            Star_2[6].GetComponent<Image>().color = new Color(Red_Second_Star[6] / MAX, Green_Second_Star[6] / MAX, Blue_Second_Star[6] / MAX, Alpha_Second_Star[6]);//α表示
            //星本体6非表示
            Star_2[5].SetActive(false);
            //星エフェクト6非表示
            StarEF_2[5].SetActive(false);
        }
        //星8表示
        if (Time_Count <= 2.36f)
        {
            //1星7を表示
            StarEF_1[6].SetActive(true);

            //星本体8表示
            Star_2[7].SetActive(true);
            Star_2[7].GetComponent<Image>().color = new Color(Red_Second_Star[7] / MAX, Green_Second_Star[7] / MAX, Blue_Second_Star[7] / MAX, Alpha_Second_Star[7]);//α表示
            //星本体7非表示
            Star_2[6].SetActive(false);
            //星エフェクト7非表示
            StarEF_2[6].SetActive(false);
        }
        //星9表示
        if (Time_Count <= 2.28f)
        {
            //1星8を表示
            StarEF_1[7].SetActive(true);

            //星本体9表示
            Star_2[8].SetActive(true);
            Star_2[8].GetComponent<Image>().color = new Color(Red_Second_Star[8] / MAX, Green_Second_Star[8] / MAX, Blue_Second_Star[8] / MAX, Alpha_Second_Star[8]);//α表示
            //星本体8非表示
            Star_2[7].SetActive(false);
            //星エフェクト8非表示
            StarEF_2[7].SetActive(false);
        }
        //星10表示
        if (Time_Count <= 2.2f)
        {
            //1星9を表示
            StarEF_1[8].SetActive(true);

            //星本体10表示
            Star_2[9].SetActive(true);
            Star_2[9].GetComponent<Image>().color = new Color(Red_Second_Star[9] / MAX, Green_Second_Star[9] / MAX, Blue_Second_Star[9] / MAX, Alpha_Second_Star[9]);//α表示
            //星本体9非表示
            Star_2[8].SetActive(false);
            //星エフェクト9非表示
            StarEF_2[8].SetActive(false);
        }
        //星11表示
        if (Time_Count <= 2.12f)
        {
            //1星10を表示
            StarEF_1[9].SetActive(true);

            //星本体11表示
            Star_2[10].SetActive(true);
            Star_2[10].GetComponent<Image>().color = new Color(Red_Second_Star[10] / MAX, Green_Second_Star[10] / MAX, Blue_Second_Star[10] / MAX, Alpha_Second_Star[10]);//α表示
            //星本体10非表示
            Star_2[9].SetActive(false);
            //星エフェクト10非表示
            StarEF_2[9].SetActive(false);
        }
        //星12表示
        if (Time_Count <= 2.04f)
        {
            //1星11を表示
            StarEF_1[10].SetActive(true);

            //星本体12表示
            Star_2[11].SetActive(true);
            Star_2[11].GetComponent<Image>().color = new Color(Red_Second_Star[11] / MAX, Green_Second_Star[11] / MAX, Blue_Second_Star[11] / MAX, Alpha_Second_Star[11]);//α表示
            //星本体11非表示
            Star_2[10].SetActive(false);
            //星エフェクト11非表示
            StarEF_2[10].SetActive(false);
        }
        //星非表示
        if (Time_Count <= 2f)
        {
            //1星12を表示
            StarEF_1[11].SetActive(true);

            //星本体12非表示
            Star_2[11].SetActive(false);
            //星エフェクト12非表示
            StarEF_2[11].SetActive(false);
        }
    }

    /// <summary>
    /// 【1星カウントダウン】【エフェクト】
    /// </summary>
    //反映ループ処理
    void StarEF_One_EF_True()
    {
        //Numberの数だけやる
        for (int i=0;i<Number;++i)
        {
            Alpha_Third_Star[i] = 1.0f;
            //星エフェクト1表示
           // StarEF_1[i].SetActive(true);
            StarEF_1[i].GetComponent<Image>().color = new Color(RED_EF / MAX, GREEN_EF / MAX, BLUE_EF / MAX, Alpha_One_Star[i]);//α表示
        }
        return;//繰り返す
    }

    /// <summary>
    /// 【1星カウントダウン】【本体】
    /// </summary>
    //星1表示アニメーションもどき
    void Star_One_true()
    {
        //反映
        StarEF_One_EF_True();
        //星1表示
        if (Time_Count <= 1.92f)
        {
            //星本体1表示
            Star_1[0].SetActive(true);
            Star_1[0].GetComponent<Image>().color = new Color(Red_One_Star[0] / MAX, Green_Second_Star[0] / MAX, Blue_One_Star[0] / MAX, Alpha_One_Star[0]);//α表示
        }
        //星2表示
        if (Time_Count <= 1.84f)
        {
            //星本体2表示
            Star_1[1].SetActive(true);
            Star_1[1].GetComponent<Image>().color = new Color(Red_One_Star[1] / MAX, Green_Second_Star[1] / MAX, Blue_One_Star[1] / MAX, Alpha_One_Star[1]);//α表示
            //星本体1非表示
            Star_1[0].SetActive(false);
            //星エフェクト1非表示
            StarEF_1[0].SetActive(false);
        }
        //星3表示
        if (Time_Count <= 1.76f)
        {
            //星本体3表示
            Star_1[2].SetActive(true);
            Star_1[2].GetComponent<Image>().color = new Color(Red_One_Star[2] / MAX, Green_Second_Star[2] / MAX, Blue_One_Star[2] / MAX, Alpha_One_Star[2]);//α表示
            //星本体2非表示
            Star_1[1].SetActive(false);
            //星エフェクト2非表示
            StarEF_1[1].SetActive(false);
        }
        //星4表示
        if (Time_Count <= 1.68f)
        {
            //星本体4表示
            Star_1[3].SetActive(true);
            Star_1[3].GetComponent<Image>().color = new Color(Red_One_Star[3] / MAX, Green_Second_Star[3] / MAX, Blue_One_Star[3] / MAX, Alpha_One_Star[3]);//α表示
            //星本体3非表示
            Star_1[2].SetActive(false);
            //星エフェクト3非表示
            StarEF_1[2].SetActive(false);
        }
        //星5表示
        if (Time_Count <= 1.6f)
        {
            //星本体5表示
            Star_1[4].SetActive(true);
            Star_1[4].GetComponent<Image>().color = new Color(Red_One_Star[4] / MAX, Green_Second_Star[4] / MAX, Blue_One_Star[4] / MAX, Alpha_One_Star[4]);//α表示
            //星本体4非表示
            Star_1[3].SetActive(false);
            //星エフェクト4非表示
            StarEF_1[3].SetActive(false);
        }
        //星6表示
        if (Time_Count <= 1.52f)
        {
            //星本体6表示
            Star_1[5].SetActive(true);
            Star_1[5].GetComponent<Image>().color = new Color(Red_One_Star[5] / MAX, Green_Second_Star[5] / MAX, Blue_One_Star[5] / MAX, Alpha_One_Star[5]);//α表示
            //星本体5非表示
            Star_1[4].SetActive(false);
            //星エフェクト5非表示
            StarEF_1[4].SetActive(false);
        }
        //星7表示
        if (Time_Count <= 1.44f)
        {
            //星本体7表示
            Star_1[6].SetActive(true);
            Star_1[6].GetComponent<Image>().color = new Color(Red_One_Star[6] / MAX, Green_Second_Star[6] / MAX, Blue_One_Star[6] / MAX, Alpha_One_Star[6]);//α表示
            //星本体6非表示
            Star_1[5].SetActive(false);
            //星エフェクト6非表示
            StarEF_1[5].SetActive(false);
        }
        //星8表示
        if (Time_Count <= 1.36f)
        {
            //星本体8表示
            Star_1[7].SetActive(true);
            Star_1[7].GetComponent<Image>().color = new Color(Red_One_Star[7] / MAX, Green_Second_Star[7] / MAX, Blue_One_Star[7] / MAX, Alpha_One_Star[7]);//α表示
            //星本体7非表示
            Star_1[6].SetActive(false);
            //星エフェクト7非表示
            StarEF_1[6].SetActive(false);
        }
        //星9表示
        if (Time_Count <= 1.28f)
        {
            //星本体9表示
            Star_1[8].SetActive(true);
            Star_1[8].GetComponent<Image>().color = new Color(Red_One_Star[8] / MAX, Green_Second_Star[8] / MAX, Blue_One_Star[8] / MAX, Alpha_One_Star[8]);//α表示
            //星本体8非表示
            Star_1[7].SetActive(false);
            //星エフェクト8非表示
            StarEF_1[7].SetActive(false);
        }
        //星10表示
        if (Time_Count <= 1.2f)
        {
            //星本体10表示
            Star_1[9].SetActive(true);
            Star_1[9].GetComponent<Image>().color = new Color(Red_One_Star[9] / MAX, Green_Second_Star[9] / MAX, Blue_One_Star[9] / MAX, Alpha_One_Star[9]);//α表示
            //星本体9非表示
            Star_1[8].SetActive(false);
            //星エフェクト9非表示
            StarEF_1[8].SetActive(false);
        }
        //星11表示
        if (Time_Count <= 1.12f)
        {
            //星本体11表示
            Star_1[10].SetActive(true);
            Star_1[10].GetComponent<Image>().color = new Color(Red_One_Star[10] / MAX, Green_Second_Star[10] / MAX, Blue_One_Star[10] / MAX, Alpha_One_Star[10]);//α表示
            //星本体10非表示
            Star_1[9].SetActive(false);
            //星エフェクト10非表示
            StarEF_1[9].SetActive(false);
        }
        //星12表示
        if (Time_Count <= 1.04f)
        {
            //星本体12表示
            Star_1[11].SetActive(true);
            Star_1[11].GetComponent<Image>().color = new Color(Red_One_Star[11] / MAX, Green_Second_Star[11] / MAX, Blue_One_Star[11] / MAX, Alpha_One_Star[11]);//α表示
            //星本体11非表示
            Star_1[10].SetActive(false);
            //星エフェクト11非表示
            StarEF_1[10].SetActive(false);
        }
        //星非表示
        if (Time_Count <= 1f)
        {
            //星本体12非表示
            Star_1[11].SetActive(false);
            //星エフェクト12非表示
            StarEF_1[11].SetActive(false);
        }
    }
}
