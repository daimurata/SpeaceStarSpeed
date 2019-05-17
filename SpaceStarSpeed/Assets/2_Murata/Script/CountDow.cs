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
    void Ster_One()
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
    void SterEF_One()
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
    void Ster_Second()
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
    void SterEF_Second()
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
    void Ster_Third()
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
    void SterEF_Third()
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
        Ster_One();
        //【1星】【輪郭】非表示
        SterEF_One();
        //【2星】【本体】非表示
        Ster_Second();
        //【2星】【輪郭】非表示
        SterEF_Second();
        //【3星】【本体】非表示
        Ster_Third();
        //【3星】【輪郭】非表示
        SterEF_Third();
    }

    //文字のα値をゼロ
    void Text_a()
    {
        //Gの本体
        Count_Zero1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //Gの輪郭
        Count_Zero1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //Gのエフェクト
        Count_Zero1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        //Oの本体
        Count_Zero2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //Oの輪郭
        Count_Zero2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //Oのエフェクト
        Count_Zero2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        //1の本体
        Count_1[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //1の輪郭
        Count_1[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //1のエフェクト
        Count_1[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        //2の本体
        Count_2[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //2の輪郭
        Count_2[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //2のエフェクト
        Count_2[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);

        //3の本体
        Count_3[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //3の輪郭
        Count_3[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //3のエフェクト
        Count_3[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
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

    void Update()
    {
        //表示
        if (Start_Change == true)
        {
            Count_Down();
        }

        //非表示
        if (Start_Change == false)
        {

        }
        
    }
    //CountDown開始
    void Count_Down()
    {

    }
    //3の文字と星を表示
    void Third_True()
    {
        //星1個の作り
        Star_1[0].SetActive(true);//本体
        StarEF_1[0].SetActive(true);//エフェクト
    }
}
