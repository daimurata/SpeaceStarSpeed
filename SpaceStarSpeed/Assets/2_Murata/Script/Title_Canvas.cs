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

    //点滅切換え用
    public bool[] Blink = new bool[3];

    //α値
    public float[]  Alpha = new float[3];
    //α値スピード
    public float[] Alpha_Speed = new float[3];

    //時間を計測
    public float Time_Count = 0.0f;

    //赤、青、緑　
    public float[] Red, Blue, Green;

    private int Color_MAX = 255;

    //シーン移動時間
    public float Go_toTime = 2;
    //α値の設定
    void Alpha_Configuration()
    {
        //α値初期0表示
        for (int i=0;i<3;++i)
        {
            Alpha[i] = 0.0f;//α値初期
        }
        return;//繰り返す
    }

    //母体1グループ
    void Body_Set()
    {
        //START文字母体
        for (int i=0;i<5;++i)
        {
            Text_Body[i].GetComponent<Image>().color = new Color(Red[0]/ Color_MAX, Green[0]/ Color_MAX, Blue[0]/ Color_MAX, Alpha[0]);//文字
        }
        return;//繰り返す
    }
    //輪郭2グループ
    void Contour_Set()
    {
        //START文字輪郭
        for (int i=0;i<5;++i)
        {
            Text_Contour[i].GetComponent<Image>().color = new Color(Red[1]/ Color_MAX, Green[1]/ Color_MAX, Blue[1]/ Color_MAX, Alpha[1]);//文字
        }
        return;//繰り返す
    }
    //エフェクト3グループ
    void Effect_Set()
    {
        //START文字エフェクト
        for (int i=0;i<5;++i)
        {
            Text_Effect[i].GetComponent<Image>().color = new Color(Red[2]/ Color_MAX, Green[2]/ Color_MAX, Blue[2]/ Color_MAX, Alpha[2]);//文字
        }
        return;//繰り返す
    }

    //母体の非表示
   void Body_False()
    {
        //母体
        for (int i=0;i<5;++i)
        {
            Text_Body[i].SetActive(false);//非表示
        }
        return;//繰り返す
    }

    //母体の表示
    void Body_True()
    {
        //母体
        for (int i=0;i<5;++i)
        {
            Text_Body[i].SetActive(true);//表示
        }
        return;//繰り返す
    }

    //輪郭の非表示
    void Contour_False()
    {
        //輪郭
        for (int i=0;i<5;++i)
        {
            Text_Contour[i].SetActive(false);//非表示
        }
        return;//繰り返す
    }

    //輪郭の表示
    void Contour_True()
    {
        //輪郭
        for (int i = 0; i < 5; ++i)
        {
            Text_Contour[i].SetActive(true);//表示
        }
        return;//繰り返す
    }

    //エフェクトの非表示
    void Effect_False()
    {
        //エフェクト
        for (int i = 0; i < 5; ++i)
        {
            Text_Effect[i].SetActive(false);//非表示
        }
        return;//繰り返す
    }
    //エフェクトの表示
    void Effect_True()
    {
        //エフェクト
        for (int i = 0; i < 5; ++i)
        {
            Text_Effect[i].SetActive(true);//表示
        }
        return;//繰り返す
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

        //点滅3点セット
        Blink_Set();

        //Iキー押すとシーン移動の際の動作をする
        if (Input.GetKeyDown(KeyCode.I))
        {
            //自動移動終了
            Change[1] = false;
            //シーン移動アニメーション起動
            Change[2] = true;
        }

        //シーン移動用
        Goto_Scene();

    }
    //これを外部に渡せば使える
    public void Change_true()
    {
        //文字表示
        Change[0] = true;
    }
    //これをスタートを押すボタンに渡す
    public void Change_Scene()
    {
        //自動移動終了
        Change[1] = false;
        //シーン移動アニメーション起動
        Change[2] = true;
    }
    
    //反映　輪郭
    void Start_Contour()
    {
        //STARTの輪郭
        for (int i = 0; i < 5; ++i)
        {
            Text_Contour[i].GetComponent<Image>().color = new Color(Red[1] / Color_MAX, Green[1] / Color_MAX, Blue[1] / Color_MAX, Alpha[1]);//反映
        }
        return;//繰り返す
    }

    //反映　エフェクト
    void Start_Effect()
    {
        //STARTのエフェクト
        for (int i = 0; i < 5; ++i)
        {
            Text_Effect[i].GetComponent<Image>().color = new Color(Red[2] / Color_MAX, Green[2] / Color_MAX, Blue[2] / Color_MAX, Alpha[2]);//反映
        }
        return;//繰り返す
    }

    //反映　本体
    void Start_Body()
    {
        //STARTの本体
        for (int i=0;i<5;++i)
        {
            Text_Body[i].GetComponent<Image>().color = new Color(Red[0] / Color_MAX, Green[0] / Color_MAX, Blue[0] / Color_MAX, Alpha[0]);//反映
        }
        return;//繰り返す
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

            //輪郭　反映
            Start_Contour();

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

                //エフェクト　反映
                Start_Effect();
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

                //本体　反映
                Start_Body();
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
                //1.5秒表示
                if (Time_Count>=1.5f)
                {
                    //1.5秒に固定
                    Time_Count = 1.5f;
                    //点滅処理開始
                    Change[1] = true;
                    //ゆっくり表示しない
                    Change[0] = false;
                }
            }
        }
    }

    //点滅3点セット
    void Blink_Set()
    {
        //点滅処理
        if (Change[1] == true)
        {
            //エフェクト点滅
            Blink_Effect();
            //輪郭点滅
            Blink_Contour();
            //母体点滅
            Blink_Body();
        }
    }

    //エフェクトを点滅させる
    void Blink_Effect()
    {
        //α値の早さ
        Alpha_Speed[2] = 1.5f;
        //STARTのエフェクト 反映
        Start_Effect();

        //Blink[0]がtrueなら
        if (Blink[2] == true)
        {
            //α値を下げる
            Alpha[2] -= Alpha_Speed[2] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha[2] < 0.0f)
            {
                //α値を0に
                Alpha[2] = 0.0f;
                //Blink[0]をfalse
                Blink[2] = false;
            }
        }
        //Blink[0]がfalseなら
        if (Blink[2] == false)
        {
            //α値を上げる
            Alpha[2] += Alpha_Speed[2] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha[2] > 1.0f)
            {
                //α値を1に
                Alpha[2] = 1.0f;
                //Blink[0]をtrue
                Blink[2] = true;
            }
        }
    }

    //輪郭を点滅させる
    void Blink_Contour()
    {
        //α値の早さ
        Alpha_Speed[1] = 1.0f;

        //輪郭 反映
        Start_Contour();

        //Blink[1]がtrueなら
        if (Blink[1] == true)
        {
            //α値を下げる
            Alpha[1] -= Alpha_Speed[1] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha[1] < 0.0f)
            {
                //α値を0に
                Alpha[1] = 0.0f;
                //Blink[0]をfalse
                Blink[1] = false;
            }
        }
        //Blink[1]がfalseなら
        if (Blink[1] == false)
        {
            //α値を上げる
            Alpha[1] += Alpha_Speed[1] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha[1] > 1.0f)
            {
                //α値を1に
                Alpha[1] = 1.0f;
                //Blink[0]をtrue
                Blink[1] = true;
            }
        }
    }

    //母体を点滅させる
    void Blink_Body()
    {
        //α値の早さ
        Alpha_Speed[0] = 0.5f;

        //本体　反映
        Start_Body();

        //Blink[1]がtrueなら
        if (Blink[0] == true)
        {
            //α値を下げる
            Alpha[0] -= Alpha_Speed[0] * Time.deltaTime;
            //α値が0以下なら
            if (Alpha[0] < 0.0f)
            {
                //α値を0に
                Alpha[0] = 0.0f;
                //Blink[0]をfalse
                Blink[0] = false;
            }
        }
        //Blink[1]がfalseなら
        if (Blink[0] == false)
        {
            //α値を上げる
            Alpha[0] += Alpha_Speed[0] * Time.deltaTime;
            //α値が1以上なら
            if (Alpha[0] > 1.0f)
            {
                //α値を1に
                Alpha[0] = 1.0f;
                //Blink[0]をtrue
                Blink[0] = true;
            }
        }
    }

    //シーンの移動
    void Goto_Scene()
    {
        //Change[2]がtrueなら
        if (Change[2]==true)
        {
            Body_Scene();
            Contour_Scene();
            Effect_Scene();
            //2秒後に
            if (Go_toTime >= 0 && Go_toTime <= 4)
            {
                //文字表示時間消すため
                Go_toTime -= Time.deltaTime;
                //点滅
                if (Blink[0] == true)
                {
                    //α値を下げる
                    Alpha[0] -= Alpha_Speed[0] * Time.deltaTime;
                    Alpha[1] -= Alpha_Speed[1] * Time.deltaTime;
                    Alpha[2] -= Alpha_Speed[2] * Time.deltaTime;
                    //Greenを下げる
                    //Green[0] -= Alpha_Speed[0] * Time.deltaTime;
                    //Blueを下げる
                    //Blue[0] -= Alpha_Speed[0] * Time.deltaTime;

                    //α値が0以下なら
                    if (Alpha[0] < 0.0f)
                    {
                        //α値を0に
                        Alpha[0] = 0.0f;
                        Alpha[1] = 0.0f;
                        Alpha[2] = 0.0f;
                        //Green
                        //Green[0] = 0.0f;
                        //Blue
                        //Blue[0] = 0.0f;
                        //Blink[0]をfalse
                        Blink[0] = false;
                    }
                }
                //非点滅
                if (Blink[0] == false)
                {
                    //α値を下げる
                    Alpha[0] += Alpha_Speed[0] * Time.deltaTime;
                    Alpha[1] += Alpha_Speed[1] * Time.deltaTime;
                    Alpha[2] += Alpha_Speed[2] * Time.deltaTime;
                    //Greenを下げる
                    //Green[0] -= Alpha_Speed[0] * Time.deltaTime;
                    //Blueを下げる
                    //Blue[0] -= Alpha_Speed[0] * Time.deltaTime;

                    //α値が0以下なら
                    if (Alpha[0] > 1.0f)
                    {
                        //α値を0に
                        Alpha[0] = 1.0f;
                        Alpha[1] = 1.0f;
                        Alpha[2] = 1.0f;
                        //Green
                        //Green[0] = 0.0f;
                        //Blue
                        //Blue[0] = 0.0f;
                        //Blink[0]をtrue
                        Blink[0] = true;
                    }
                }
            }
            //0秒以下なら
            if (Go_toTime <= 0)
            {
                //α値を下げる
                Alpha[0] -= Alpha_Speed[0] * Time.deltaTime;
                Alpha[1] -= Alpha_Speed[1] * Time.deltaTime;
                Alpha[2] -= Alpha_Speed[2] * Time.deltaTime;
                //a値が0以下
                if (Alpha[0] <= 0)
                {
                    //α値を0
                    Alpha[0] = 0;
                }
                //a値が0以下
                if (Alpha[1] <= 0)
                {
                    //α値を0
                    Alpha[1] = 0;
                }
                //a値が0以下
                if (Alpha[2] <= 0)
                {
                    //α値を0
                    Alpha[2] = 0;
                }
            }
        }
    }
    //母体のシーン移動際に変更
    void Body_Scene()
    {
        //α値の速さ
        Alpha_Speed[0] = 0.5f;

        //反映　本体
        Start_Body();
    }

    //輪郭のシーン移動際に変更
    void Contour_Scene()
    {
        //α値の速さ
        Alpha_Speed[1] = 0.5f;

        //反映　輪郭
        Start_Contour();
    }
    //エフェクトのシーン移動際に変更
    void Effect_Scene()
    {
        //α値の速さ
        Alpha_Speed[2] = 0.5f;

        //反映　エフェクト
        Start_Effect();
    }
}
