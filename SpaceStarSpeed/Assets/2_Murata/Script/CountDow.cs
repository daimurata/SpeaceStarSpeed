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

    //【子】Gの本体
    public GameObject[] Count_Zero1 = new GameObject[3];
    //【子】Oの本体
    public GameObject[] Count_Zero2 = new GameObject[3];
    //【子】1の本体
    public GameObject[] Count_1 = new GameObject[3];
    //【子】2の本体
    public GameObject[] Count_2 = new GameObject[3];
    //【子】3の本体
    public GameObject[] Count_3 = new GameObject[3];

    //【子】1の星本体　12個
    public GameObject[] Star_1 = new GameObject[12];
    //【子】1の星輪郭　12個　
    public GameObject[] StarEF_1 = new GameObject[12];
    //【子】2の星本体　12個
    public GameObject[] Star_2 = new GameObject[12];
    //【子】2の星輪郭　12個　
    public GameObject[] StarEF_2 = new GameObject[12];
    //【子】3の星本体　12個
    public GameObject[] Star_3 = new GameObject[12];
    //【子】3の星輪郭　12個　
    public GameObject[] StarEF_3 = new GameObject[12];

    // カウント表示切替
    public bool Start_Change = false;

    //時間
    public float Time_Count = 4.0f;

    //GOの文字α値
    public float[] Alpha_Zero = new float[3];
    //1の文字α値
    public float[] Alpha_One = new float[3];
    //2の文字α値
    public float[] Alpha_Second = new float[3];
    //3の文字α値
    public float[] Alpha_Third = new float[3];

    //αのスピード
    public float Alpha_Speed = 0.01f;
    //テキスト 非表示
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

    //GO　非表示
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
    //1 非表示
    void Text_One()
    {
        //1本体
        Count_1[0].SetActive(false);//母体
        Count_1[1].SetActive(false);//輪郭
        Count_1[2].SetActive(false);//エフェクト
    }
    //2　非表示
    void Text_Second()
    {
        //2本体
        Count_2[0].SetActive(false);//母体
        Count_2[1].SetActive(false);//輪郭
        Count_2[2].SetActive(false);//エフェクト
    }
    //3　非表示
    void Text_Third()
    {
        //3本体
        Count_3[0].SetActive(false);//母体
        Count_3[1].SetActive(false);//輪郭
        Count_3[2].SetActive(false);//エフェクト
    }


    //【1星】本体　非表示
    void Star_One()
    {
        //星1～12
        Star_1[0].SetActive(false);//星1
        Star_1[1].SetActive(false);//星2
        Star_1[2].SetActive(false);//星3
        Star_1[3].SetActive(false);//星4
        Star_1[4].SetActive(false);//星5
        Star_1[5].SetActive(false);//星6
        Star_1[6].SetActive(false);//星7
        Star_1[7].SetActive(false);//星8
        Star_1[8].SetActive(false);//星9
        Star_1[9].SetActive(false);//星10
        Star_1[10].SetActive(false);//星11
        Star_1[11].SetActive(false);//星12
    }
    //【1星】輪郭　非表示
    void StarEF_One()
    {
        //輪郭1～12
        StarEF_1[0].SetActive(false);//輪郭1
        StarEF_1[1].SetActive(false);//輪郭2
        StarEF_1[2].SetActive(false);//輪郭3
        StarEF_1[3].SetActive(false);//輪郭4
        StarEF_1[4].SetActive(false);//輪郭5
        StarEF_1[5].SetActive(false);//輪郭6
        StarEF_1[6].SetActive(false);//輪郭7
        StarEF_1[7].SetActive(false);//輪郭8
        StarEF_1[8].SetActive(false);//輪郭9
        StarEF_1[9].SetActive(false);//輪郭10
        StarEF_1[10].SetActive(false);//輪郭11
        StarEF_1[11].SetActive(false);//輪郭12
    }
    //【2星】本体　非表示
    void Star_Second()
    {
        //星1～12
        Star_2[0].SetActive(false);//星1
        Star_2[1].SetActive(false);//星2
        Star_2[2].SetActive(false);//星3
        Star_2[3].SetActive(false);//星4
        Star_2[4].SetActive(false);//星5
        Star_2[5].SetActive(false);//星6
        Star_2[6].SetActive(false);//星7
        Star_2[7].SetActive(false);//星8
        Star_2[8].SetActive(false);//星9
        Star_2[9].SetActive(false);//星10
        Star_2[10].SetActive(false);//星11
        Star_2[11].SetActive(false);//星12
    }
    //【2星】輪郭　非表示
    void StarEF_Second()
    {
        //輪郭1～12
        StarEF_2[0].SetActive(false);//輪郭1
        StarEF_2[1].SetActive(false);//輪郭2
        StarEF_2[2].SetActive(false);//輪郭3
        StarEF_2[3].SetActive(false);//輪郭4
        StarEF_2[4].SetActive(false);//輪郭5
        StarEF_2[5].SetActive(false);//輪郭6
        StarEF_2[6].SetActive(false);//輪郭7
        StarEF_2[7].SetActive(false);//輪郭8
        StarEF_2[8].SetActive(false);//輪郭9
        StarEF_2[9].SetActive(false);//輪郭10
        StarEF_2[10].SetActive(false);//輪郭11
        StarEF_2[11].SetActive(false);//輪郭12
    }
    //【3星】本体　非表示
    void Star_Third()
    {
        //星1～12
        Star_3[0].SetActive(false);//星1
        Star_3[1].SetActive(false);//星2
        Star_3[2].SetActive(false);//星3
        Star_3[3].SetActive(false);//星4
        Star_3[4].SetActive(false);//星5
        Star_3[5].SetActive(false);//星6
        Star_3[6].SetActive(false);//星7
        Star_3[7].SetActive(false);//星8
        Star_3[8].SetActive(false);//星9
        Star_3[9].SetActive(false);//星10
        Star_3[10].SetActive(false);//星11
        Star_3[11].SetActive(false);//星12
    }
    //【3星】輪郭　非表示
    void StarEF_Third()
    {
        //輪郭1～12
        StarEF_3[0].SetActive(false);//輪郭1
        StarEF_3[1].SetActive(false);//輪郭2
        StarEF_3[2].SetActive(false);//輪郭3
        StarEF_3[3].SetActive(false);//輪郭4
        StarEF_3[4].SetActive(false);//輪郭5
        StarEF_3[5].SetActive(false);//輪郭6
        StarEF_3[6].SetActive(false);//輪郭7
        StarEF_3[7].SetActive(false);//輪郭8
        StarEF_3[8].SetActive(false);//輪郭9
        StarEF_3[9].SetActive(false);//輪郭10
        StarEF_3[10].SetActive(false);//輪郭11
        StarEF_3[11].SetActive(false);//輪郭12
    }

    //星　非表示
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

    //文字のα値をゼロ
    void Text_a()
    {
        //Gの本体
        Count_Zero1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[0]);
        //Gの輪郭
        Count_Zero1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[1]);
        //Gのエフェクト
        Count_Zero1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[2]);

        //Oの本体
        Count_Zero2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[0]);
        //Oの輪郭
        Count_Zero2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[1]);
        //Oのエフェクト
        Count_Zero2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[2]);

        //1の本体
        Count_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_One[0]);
        //1の輪郭
        Count_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_One[1]);
        //1のエフェクト
        Count_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_One[2]);

        //2の本体
        Count_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Second[0]);
        //2の輪郭
        Count_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Second[1]);
        //2のエフェクト
        Count_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Second[2]);

        //3の本体
        Count_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Third[0]);
        //3の輪郭
        Count_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Third[1]);
        //3のエフェクト
        Count_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Third[2]);
    }

    //1星の本体α値をゼロ
    void OneStar_a()
    {
        //星1～12本体
        Star_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_1[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }
    //1星のEFα値をゼロ
    void OneStarEF_a()
    {
        //星1～12本体
        StarEF_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_1[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }

    //2星の本体α値をゼロ
    void SecondStar_a()
    {
        //星1～12本体
        Star_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_2[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }
    //2星のEFα値をゼロ
    void SecondStarEF_a()
    {
        //星1～12本体
        StarEF_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_2[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }

    //3星の本体α値をゼロ
    void ThirdStar_a()
    {
        //星1～12本体
        Star_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        Star_3[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }
    //3星のEFα値をゼロ
    void ThirdStarEF_a()
    {
        //星1～12本体
        StarEF_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
        StarEF_3[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0f);
    }

    //星のα値集合体
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
    }
    //外部で起動させる時
    public void Change_true()
    {
        //カウントダウン起動
        Start_Change = true;
    } 
    //時間経過処理
    void Count_Dow_Start()
    {
        //時間経過
        Time_Count -= 0.01f;
        //3の文字表示開始
        if (Time_Count <= 4.0f)//&&Time_Count>=3.0f)
        {
            //3の文字親表示
            Count_Dow[3].SetActive(true);
            Alpha_Third[1] += Alpha_Speed;

            StarEF_One_true();

            if (Time_Count <= 3.5f)
            {
                //3の母体表示
                Count_3[0].SetActive(true);
                Alpha_Third[0] += Alpha_Speed;
                //3の母体α値100％
                Count_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Third[0]);
            }

            //3の輪郭表示
            Count_3[1].SetActive(true);
            //3の輪郭α値100％
            Count_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Third[1]);

            if (Time_Count <= 3.8f)
            {
                //3のエフェクト表示
                Count_3[2].SetActive(true);
                Alpha_Third[2] += Alpha_Speed;
                //3のエフェクトα値100％
                Count_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Third[2]);
            }
        }
        //3秒以下なら2の文字表示
        if (Time_Count <= 3.0f)// && Time_Count >= 2.0f)
        {
            //3の文字親非表示
            Count_3[0].SetActive(false);
            //3の文字母体非表示
            Count_3[1].SetActive(false);
            //3の文字輪郭非表示
            Count_3[2].SetActive(false);
            //3の文字エフェクト非表示
            Count_Dow[3].SetActive(false);
            Alpha_Third[0] = 0.0f;
            Alpha_Third[0] = 0.0f;
            Alpha_Third[0] = 0.0f;

            //2の文字親表示
            Count_Dow[2].SetActive(true);
            Alpha_Second[1] += Alpha_Speed;

            Second_One_true();

            if (Time_Count <= 2.5f)
            {
                //2の文字母体表示
                Count_2[0].SetActive(true);
                Alpha_Second[0] += Alpha_Speed;
                //2の文字母体α値100％
                Count_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Second[0]);
            }

            //2の文字輪郭表示
            Count_2[1].SetActive(true);
            //2の文字輪郭α値100％
            Count_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Second[1]);

            if (Time_Count <= 2.8f)
            {
                //2の文字エフェクト表示
                Count_2[2].SetActive(true);
                Alpha_Second[2] += Alpha_Speed;
                //2の文字エフェクトα値100％
                Count_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Second[2]);
            }
        }
        //2秒以下なら1の文字表示
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
            Alpha_Second[0] = 0.0f;
            Alpha_Second[1] = 0.0f;
            Alpha_Second[2] = 0.0f;

            //1の文字親表示
            Count_Dow[1].SetActive(true);
            Alpha_One[1] += Alpha_Speed;

            One_One_true();

            if (Time_Count <= 1.5f)
            {
                //1の文字母体表示
                Count_1[0].SetActive(true);
                Alpha_One[0] += Alpha_Speed;
                //1の文字母体α値100％
                Count_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_One[0]);
            }

            //1の文字輪郭表示
            Count_1[1].SetActive(true);
            //1の文字輪郭α値100％
            Count_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_One[1]);

            if (Time_Count <= 1.8f)
            {
                //1の文字エフェクト表示
                Count_1[2].SetActive(true);
                Alpha_One[2] += Alpha_Speed;
                //1の文字エフェクト表示α値100％
                Count_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_One[2]);
            }
        }
        //1秒以下ならGOの文字表示
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
            Alpha_One[0] = 0.0f;
            Alpha_One[1] = 0.0f;
            Alpha_One[2] = 0.0f;

            //GOの文字親表示
            Count_Dow[0].SetActive(true);
            Alpha_Zero[1] += Alpha_Speed;
            if (Time_Count <= 0.5f)
            {
                //Gの文字母体表示
                Count_Zero1[0].SetActive(true);
                Alpha_Zero[0] += Alpha_Speed;
                //Gの文字母体α値100％
                Count_Zero1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[0]);

                //Oの文字母体表示
                Count_Zero2[0].SetActive(true);
                //Oの文字母体α値100％
                Count_Zero2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[0]);
            }

            //Gの文字輪郭表示
            Count_Zero1[1].SetActive(true);
            //Gの文字輪郭α値100％
            Count_Zero1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[1]);

            //Oの文字輪郭表示
            Count_Zero2[1].SetActive(true);
            //Oの文字輪郭α値100％
            Count_Zero2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[1]);

            if (Time_Count <= 0.8f)
            {
                //Gの文字エフェクト表示
                Count_Zero1[2].SetActive(true);
                Alpha_Zero[2] += Alpha_Speed;
                //Gの文字エフェクトα値100％
                Count_Zero1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[2]);

                //Oの文字エフェクト表示
                Count_Zero2[2].SetActive(true);
                //Oの文字エフェクトα値100％
                Count_Zero2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha_Zero[2]);
            }
        }
        //0秒以下になったら全て非表示
        if (Time_Count <= 0.0f)
        {
            //GOの文字親非表示
            Count_Dow[0].SetActive(false);
            //Gの文字母体非表示
            Count_Zero1[0].SetActive(false);
            //Gの文字輪郭非表示
            Count_Zero1[1].SetActive(false);
            //Gの文字エフェクト非表示
            Count_Zero1[2].SetActive(false);

            //Oの文字母体非表示
            Count_Zero2[0].SetActive(false);
            //Oの文字輪郭非表示
            Count_Zero2[1].SetActive(false);
            //Oの文字エフェクト非表示
            Count_Zero2[2].SetActive(false);


            //時間はマイナス表示
            Time_Count = -1.0f;
            Alpha_Zero[0] = 0.0f;
            Alpha_Zero[1] = 0.0f;
            Alpha_Zero[2] = 0.0f;
            Alpha_Speed = 0.0f;

            //役割終了
            Start_Change=false;
        }
    }


    //星3表示アニメーションもどき
    void StarEF_One_true()
    {
        //星エフェクト1表示
        StarEF_3[0].SetActive(true);
        StarEF_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト2表示
        StarEF_3[1].SetActive(true);
        StarEF_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト3表示
        StarEF_3[2].SetActive(true);
        StarEF_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト4表示
        StarEF_3[3].SetActive(true);
        StarEF_3[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト5表示
        StarEF_3[4].SetActive(true);
        StarEF_3[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト6表示
        StarEF_3[5].SetActive(true);
        StarEF_3[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト7表示
        StarEF_3[6].SetActive(true);
        StarEF_3[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト8表示
        StarEF_3[7].SetActive(true);
        StarEF_3[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト9表示
        StarEF_3[8].SetActive(true);
        StarEF_3[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト10表示
        StarEF_3[9].SetActive(true);
        StarEF_3[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト11表示
        StarEF_3[10].SetActive(true);
        StarEF_3[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト12表示
        StarEF_3[11].SetActive(true);
        StarEF_3[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示

        //星1表示
        if (Time_Count<=3.92f)
        {
            //星本体1表示
            Star_3[0].SetActive(true);
            Star_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        }
        //星2表示
        if (Time_Count<=3.84f)
        {
            //星本体2表示
            Star_3[1].SetActive(true);
            Star_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体1非表示
            Star_3[0].SetActive(false);
            //星エフェクト1非表示
            StarEF_3[0].SetActive(false);
        }
        //星3表示
        if (Time_Count<=3.76f)
        {
            //星本体3表示
            Star_3[2].SetActive(true);
            Star_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体2非表示
            Star_3[1].SetActive(false);
            //星エフェクト2非表示
            StarEF_3[1].SetActive(false);
        }
        //星4表示
        if (Time_Count <= 3.68f)
        {
            //星本体4表示
            Star_3[3].SetActive(true);
            Star_3[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体3非表示
            Star_3[2].SetActive(false);
            //星エフェクト3非表示
            StarEF_3[2].SetActive(false);
        }
        //星5表示
        if (Time_Count <= 3.6f)
        {
            //星本体5表示
            Star_3[4].SetActive(true);
            Star_3[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体4非表示
            Star_3[3].SetActive(false);
            //星エフェクト4非表示
            StarEF_3[3].SetActive(false);
        }
        //星6表示
        if (Time_Count <= 3.52f)
        {
            //星本体6表示
            Star_3[5].SetActive(true);
            Star_3[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体5非表示
            Star_3[4].SetActive(false);
            //星エフェクト5非表示
            StarEF_3[4].SetActive(false);
        }
        //星7表示
        if (Time_Count<=3.44f)
        {
            //星本体7表示
            Star_3[6].SetActive(true);
            Star_3[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体6非表示
            Star_3[5].SetActive(false);
            //星エフェクト6非表示
            StarEF_3[5].SetActive(false);
        }
        //星8表示
        if (Time_Count<=3.36f)
        {
            //星本体8表示
            Star_3[7].SetActive(true);
            Star_3[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体7非表示
            Star_3[6].SetActive(false);
            //星エフェクト7非表示
            StarEF_3[6].SetActive(false);
        }
        //星9表示
        if (Time_Count <= 3.28f)
        {
            //星本体9表示
            Star_3[8].SetActive(true);
            Star_3[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体8非表示
            Star_3[7].SetActive(false);
            //星エフェクト8非表示
            StarEF_3[7].SetActive(false);
        }
        //星10表示
        if (Time_Count<=3.2f)
        {
            //星本体10表示
            Star_3[9].SetActive(true);
            Star_3[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体9非表示
            Star_3[8].SetActive(false);
            //星エフェクト9非表示
            StarEF_3[8].SetActive(false);
        }
        //星11表示
        if (Time_Count<=3.12f)
        {
            //星本体11表示
            Star_3[10].SetActive(true);
            Star_3[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体10非表示
            Star_3[9].SetActive(false);
            //星エフェクト10非表示
            StarEF_3[9].SetActive(false);
        }
        //星12表示
        if (Time_Count<=3.04f)
        {
            //星本体12表示
            Star_3[11].SetActive(true);
            Star_3[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体11非表示
            Star_3[10].SetActive(false);
            //星エフェクト11非表示
            StarEF_3[10].SetActive(false);
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

    //星2表示アニメーションもどき
    void Second_One_true()
    {
        //星エフェクト1表示
        StarEF_2[0].SetActive(true);
        StarEF_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト2表示
        StarEF_2[1].SetActive(true);
        StarEF_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト3表示
        StarEF_2[2].SetActive(true);
        StarEF_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト4表示
        StarEF_2[3].SetActive(true);
        StarEF_2[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト5表示
        StarEF_2[4].SetActive(true);
        StarEF_2[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト6表示
        StarEF_2[5].SetActive(true);
        StarEF_2[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト7表示
        StarEF_2[6].SetActive(true);
        StarEF_2[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト8表示
        StarEF_2[7].SetActive(true);
        StarEF_2[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト9表示
        StarEF_2[8].SetActive(true);
        StarEF_2[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト10表示
        StarEF_2[9].SetActive(true);
        StarEF_2[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト11表示
        StarEF_2[10].SetActive(true);
        StarEF_2[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト12表示
        StarEF_2[11].SetActive(true);
        StarEF_2[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示

        //星1表示
        if (Time_Count <= 2.92f)
        {
            //星本体1表示
            Star_2[0].SetActive(true);
            Star_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        }
        //星2表示
        if (Time_Count <= 2.84f)
        {
            //星本体2表示
            Star_2[1].SetActive(true);
            Star_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体1非表示
            Star_2[0].SetActive(false);
            //星エフェクト1非表示
            StarEF_2[0].SetActive(false);
        }
        //星3表示
        if (Time_Count <= 2.76f)
        {
            //星本体3表示
            Star_2[2].SetActive(true);
            Star_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体2非表示
            Star_2[1].SetActive(false);
            //星エフェクト2非表示
            StarEF_2[1].SetActive(false);
        }
        //星4表示
        if (Time_Count <= 2.68f)
        {
            //星本体4表示
            Star_2[3].SetActive(true);
            Star_2[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体3非表示
            Star_2[2].SetActive(false);
            //星エフェクト3非表示
            StarEF_2[2].SetActive(false);
        }
        //星5表示
        if (Time_Count <= 2.6f)
        {
            //星本体5表示
            Star_2[4].SetActive(true);
            Star_2[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体4非表示
            Star_2[3].SetActive(false);
            //星エフェクト4非表示
            StarEF_2[3].SetActive(false);
        }
        //星6表示
        if (Time_Count <= 2.52f)
        {
            //星本体6表示
            Star_2[5].SetActive(true);
            Star_2[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体5非表示
            Star_2[4].SetActive(false);
            //星エフェクト5非表示
            StarEF_2[4].SetActive(false);
        }
        //星7表示
        if (Time_Count <= 2.44f)
        {
            //星本体7表示
            Star_2[6].SetActive(true);
            Star_2[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体6非表示
            Star_2[5].SetActive(false);
            //星エフェクト6非表示
            StarEF_2[5].SetActive(false);
        }
        //星8表示
        if (Time_Count <= 2.36f)
        {
            //星本体8表示
            Star_2[7].SetActive(true);
            Star_2[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体7非表示
            Star_2[6].SetActive(false);
            //星エフェクト7非表示
            StarEF_2[6].SetActive(false);
        }
        //星9表示
        if (Time_Count <= 2.28f)
        {
            //星本体9表示
            Star_2[8].SetActive(true);
            Star_2[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体8非表示
            Star_2[7].SetActive(false);
            //星エフェクト8非表示
            StarEF_2[7].SetActive(false);
        }
        //星10表示
        if (Time_Count <= 2.2f)
        {
            //星本体10表示
            Star_2[9].SetActive(true);
            Star_2[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体9非表示
            Star_2[8].SetActive(false);
            //星エフェクト9非表示
            StarEF_2[8].SetActive(false);
        }
        //星11表示
        if (Time_Count <= 2.12f)
        {
            //星本体11表示
            Star_2[10].SetActive(true);
            Star_2[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体10非表示
            Star_2[9].SetActive(false);
            //星エフェクト10非表示
            StarEF_2[9].SetActive(false);
        }
        //星12表示
        if (Time_Count <= 2.04f)
        {
            //星本体12表示
            Star_2[11].SetActive(true);
            Star_2[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
            //星本体11非表示
            Star_2[10].SetActive(false);
            //星エフェクト11非表示
            StarEF_2[10].SetActive(false);
        }
        //星非表示
        if (Time_Count <= 2f)
        {
            //星本体12非表示
            Star_2[11].SetActive(false);
            //星エフェクト12非表示
            StarEF_2[11].SetActive(false);
        }
    }

    //星1表示アニメーションもどき
    void One_One_true()
    {
        //星エフェクト1表示
        StarEF_1[0].SetActive(true);
        StarEF_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト2表示
        StarEF_1[1].SetActive(true);
        StarEF_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト3表示
        StarEF_1[2].SetActive(true);
        StarEF_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト4表示
        StarEF_1[3].SetActive(true);
        StarEF_1[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト5表示
        StarEF_1[4].SetActive(true);
        StarEF_1[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト6表示
        StarEF_1[5].SetActive(true);
        StarEF_1[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト7表示
        StarEF_1[6].SetActive(true);
        StarEF_1[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト8表示
        StarEF_1[7].SetActive(true);
        StarEF_1[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト9表示
        StarEF_1[8].SetActive(true);
        StarEF_1[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト10表示
        StarEF_1[9].SetActive(true);
        StarEF_1[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト11表示
        StarEF_1[10].SetActive(true);
        StarEF_1[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        //星エフェクト12表示
        StarEF_1[11].SetActive(true);
        StarEF_1[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示

        //星1表示
        if (Time_Count <= 1.92f)
        {
            //星本体1表示
            Star_1[0].SetActive(true);
            Star_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
        }
        //星2表示
        if (Time_Count <= 1.84f)
        {
            //星本体2表示
            Star_1[1].SetActive(true);
            Star_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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
            Star_1[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//α表示
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

    /*
    //CountDown開始
    void Count_Down()
    {
        //表示
        if (Start_Change == true)
        {
     
        }

        //非表示
        if (Start_Change == false)
        {

        }
    }
    //3の文字と星を表示
    void Third_True()
    {
        //3文字
        Count_3[0].SetActive(true);//母体
        Count_3[1].SetActive(true);//輪郭
        Count_3[2].SetActive(true);//エフェクト
        Count_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//母体　α値100％
        Count_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//輪郭　α値100％
        Count_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星1個の作り
        Star_3[0].SetActive(true);//本体
        StarEF_3[0].SetActive(true);//エフェクト
        Star_3[0].GetComponent<Image>().color = new Color(1.0f,1.0f,1.0f,1.0f);//本体　α値100％
        StarEF_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星2個の作り
        Star_3[1].SetActive(true);//本体
        StarEF_3[1].SetActive(true);//エフェクト
        Star_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星3個の作り
        Star_3[2].SetActive(true);//本体
        StarEF_3[2].SetActive(true);//エフェクト
        Star_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星4個の作り
        Star_3[3].SetActive(true);//本体
        StarEF_3[3].SetActive(true);//エフェクト
        Star_3[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星5個の作り
        Star_3[4].SetActive(true);//本体
        StarEF_3[4].SetActive(true);//エフェクト
        Star_3[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星6個の作り
        Star_3[5].SetActive(true);//本体
        StarEF_3[5].SetActive(true);//エフェクト
        Star_3[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星7個の作り
        Star_3[6].SetActive(true);//本体
        StarEF_3[6].SetActive(true);//エフェクト
        Star_3[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星8個の作り
        Star_3[7].SetActive(true);//本体
        StarEF_3[7].SetActive(true);//エフェクト
        Star_3[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星9個の作り
        Star_3[8].SetActive(true);//本体
        StarEF_3[8].SetActive(true);//エフェクト
        Star_3[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星10個の作り
        Star_3[9].SetActive(true);//本体
        StarEF_3[9].SetActive(true);//エフェクト
        Star_3[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星11個の作り
        Star_3[10].SetActive(true);//本体
        StarEF_3[10].SetActive(true);//エフェクト
        Star_3[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星12個の作り
        Star_3[11].SetActive(true);//本体
        StarEF_3[11].SetActive(true);//エフェクト
        Star_3[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_3[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

    }

    //2の文字と星を表示
    void Second_True()
    {
        //2文字
        Count_2[0].SetActive(true);//母体
        Count_2[1].SetActive(true);//輪郭
        Count_2[2].SetActive(true);//エフェクト
        Count_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//母体　α値100％
        Count_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//輪郭　α値100％
        Count_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星1個の作り
        Star_2[0].SetActive(true);//本体
        StarEF_2[0].SetActive(true);//エフェクト
        Star_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星2個の作り
        Star_2[1].SetActive(true);//本体
        StarEF_2[1].SetActive(true);//エフェクト
        Star_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星3個の作り
        Star_2[2].SetActive(true);//本体
        StarEF_2[2].SetActive(true);//エフェクト
        Star_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星4個の作り
        Star_2[3].SetActive(true);//本体
        StarEF_2[3].SetActive(true);//エフェクト
        Star_2[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星5個の作り
        Star_2[4].SetActive(true);//本体
        StarEF_2[4].SetActive(true);//エフェクト
        Star_2[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星6個の作り
        Star_2[5].SetActive(true);//本体
        StarEF_2[5].SetActive(true);//エフェクト
        Star_2[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星7個の作り
        Star_2[6].SetActive(true);//本体
        StarEF_2[6].SetActive(true);//エフェクト
        Star_2[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星8個の作り
        Star_2[7].SetActive(true);//本体
        StarEF_2[7].SetActive(true);//エフェクト
        Star_2[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星9個の作り
        Star_2[8].SetActive(true);//本体
        StarEF_2[8].SetActive(true);//エフェクト
        Star_2[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星10個の作り
        Star_2[9].SetActive(true);//本体
        StarEF_2[9].SetActive(true);//エフェクト
        Star_2[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星11個の作り
        Star_2[10].SetActive(true);//本体
        StarEF_2[10].SetActive(true);//エフェクト
        Star_2[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星12個の作り
        Star_2[11].SetActive(true);//本体
        StarEF_2[11].SetActive(true);//エフェクト
        Star_2[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_2[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％
    }

    //1の文字と星を表示
    void One_True()
    {
        //3文字
        Count_1[0].SetActive(true);//母体
        Count_1[1].SetActive(true);//輪郭
        Count_1[2].SetActive(true);//エフェクト
        Count_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//母体　α値100％
        Count_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//輪郭　α値100％
        Count_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星1個の作り
        Star_1[0].SetActive(true);//本体
        StarEF_1[0].SetActive(true);//エフェクト
        Star_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星2個の作り
        Star_1[1].SetActive(true);//本体
        StarEF_1[1].SetActive(true);//エフェクト
        Star_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星3個の作り
        Star_1[2].SetActive(true);//本体
        StarEF_1[2].SetActive(true);//エフェクト
        Star_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星4個の作り
        Star_1[3].SetActive(true);//本体
        StarEF_1[3].SetActive(true);//エフェクト
        Star_1[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[3].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星5個の作り
        Star_1[4].SetActive(true);//本体
        StarEF_1[4].SetActive(true);//エフェクト
        Star_1[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[4].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星6個の作り
        Star_1[5].SetActive(true);//本体
        StarEF_1[5].SetActive(true);//エフェクト
        Star_1[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[5].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星7個の作り
        Star_1[6].SetActive(true);//本体
        StarEF_1[6].SetActive(true);//エフェクト
        Star_1[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[6].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星8個の作り
        Star_1[7].SetActive(true);//本体
        StarEF_1[7].SetActive(true);//エフェクト
        Star_1[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[7].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星9個の作り
        Star_1[8].SetActive(true);//本体
        StarEF_1[8].SetActive(true);//エフェクト
        Star_1[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[8].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星10個の作り
        Star_1[9].SetActive(true);//本体
        StarEF_1[9].SetActive(true);//エフェクト
        Star_1[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[9].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星11個の作り
        Star_1[10].SetActive(true);//本体
        StarEF_1[10].SetActive(true);//エフェクト
        Star_1[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[10].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

        //星12個の作り
        Star_1[11].SetActive(true);//本体
        StarEF_1[11].SetActive(true);//エフェクト
        Star_1[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//本体　α値100％
        StarEF_1[11].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);//エフェクト　α値100％

    }*/
}
