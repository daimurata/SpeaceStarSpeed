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
        //α値初期スピード
        Alpha_Speed[0] = 0.1f;//母体 01
        Alpha_Speed[1] = 0.2f;//輪郭 02
        Alpha_Speed[2] = 0.3f;//エフェクト 03

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
    // Update is called once per frame
    void Update()
    {   //ゆっくり表示
        OLL_True();
      
           //NEWObjがTRUEの時だけ
            if (this.gameObject.activeSelf)
            {
                //文字スタート文字表示
                Change[0] = true;
            }
        //3秒表示
        if (Time_Count >= 3.0f)
        {

            //点滅処理開始
            Change[1] = true;
            Change[0] = false;
        }
        if (Time_Count >= 6.0f)
        {
            Change[1] = false;
            Change[0] = true;
        }

        //点滅処理
        if (Change[1] == true)
        {
            Alpha_Speed[1] = 0.2f;
            Alpha[1] -= Alpha_Speed[1];
            Text_Contour[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//1
            Text_Contour[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//2
            Text_Contour[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//3
            if (Alpha[1] <= 0.1f)
            {
                Alpha_Speed[1] = 0.0f;
                Alpha[1] = 0.1f;
            }
            if (Alpha[1] <= 0.5f)
            {
                Alpha_Speed[2] = 0.3f;
                Alpha[2] -= Alpha_Speed[2];

                //エフェクト点滅
                Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//1
                Text_Effect[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//2
                Text_Effect[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//3
            }
            if (Alpha[2] <= 0.1f)
            {
                Alpha_Speed[2] = 0.0f;
                Alpha[2] = 0.1f;
            }
            if (Alpha[2] <= 0.5f)
            {
                Alpha_Speed[0] = 0.1f;
                Alpha[0] -= Alpha_Speed[0];

                //エフェクト点滅
                Text_Body[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//1
                Text_Body[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//2
                Text_Body[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//3
            }
            if (Alpha[0] <= 0.1f)
            {
                Alpha_Speed[0] = 0.0f;
                Alpha[0] = 0.1f;

                //時間を加算
                Time_Count += Time.deltaTime;

            }
        }
          
       
    }
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
            //NEWの輪郭
            Text_Contour[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//1
            Text_Contour[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//2
            Text_Contour[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[1]);//3
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
                //NEWのエフェクト
                Text_Effect[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//1
                Text_Effect[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//2
                Text_Effect[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[2]);//3
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
                //NEWの母体
                Text_Body[0].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//1
                Text_Body[1].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//2
                Text_Body[2].GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, Alpha[0]);//3
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
              
            }
            }

        }
    }
