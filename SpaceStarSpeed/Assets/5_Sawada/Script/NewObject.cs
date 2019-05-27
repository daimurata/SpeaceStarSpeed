using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewObject : MonoBehaviour
{  //文字の母体
    public GameObject[] Text_Body = new GameObject[3];
    //文字の輪郭
    public GameObject[] Text_Contour = new GameObject[3];
    //文字のエフェクト
    public GameObject[] Text_Effect = new GameObject[3];
    //切替用
    public bool[] Change = new bool[3];

    //α値
    public float[] Alpha = new float[3];
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


    }
    //母体1グループ
    void Body_Set()
    {
        //NEW文字母体
        Text_Body[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//N
        Text_Body[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//E
        Text_Body[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//W
    }
    //輪郭2グループ
    void Contour_Set()
    {
        //NEW文字輪郭
        Text_Contour[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//N
        Text_Contour[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//E
        Text_Contour[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//W


    }
    //エフェクト3グループ
    void Effect_Set()
    {//NEW文字エフェクト
        Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//N
        Text_Effect[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//E
        Text_Effect[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//W
    } //母体の非表示
    void Body_False()
    {
        //母体
        Text_Body[0].SetActive(false);//1
        Text_Body[1].SetActive(false);//2
        Text_Body[2].SetActive(false);//3
    }
        //母体の表示
        void Body_True()
    {
        //母体
        Text_Body[0].SetActive(true);//1
        Text_Body[1].SetActive(true);//2
        Text_Body[2].SetActive(true);//3
    } //輪郭の非表示
    void Contour_False()
    {
        //輪郭
        Text_Contour[0].SetActive(false);//1
        Text_Contour[1].SetActive(false);//2
        Text_Contour[2].SetActive(false);//3
    }
    //輪郭の表示
    void Contour_True()
    {
        //輪郭
        Text_Contour[0].SetActive(true);//1
        Text_Contour[1].SetActive(true);//2
        Text_Contour[2].SetActive(true);//3
    }
    //エフェクトの非表示
    void Effect_False()
    {
        //エフェクト
        Text_Effect[0].SetActive(false);//1
        Text_Effect[1].SetActive(false);//2
        Text_Effect[2].SetActive(false);//3
    }
    //エフェクトの表示
    void Effect_True()
    {
        //エフェクト
        Text_Effect[0].SetActive(true);//1
        Text_Effect[1].SetActive(true);//2
        Text_Effect[2].SetActive(true);//3
    }

    //lled before the first frame update
    //初期設定
    void Start()
    { 
        //スペースキーを押すと
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //文字スタート文字表示
            Change[0] = true;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
