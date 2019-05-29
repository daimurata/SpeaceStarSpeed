using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    //フェードさせてからシーン移動までさせる

    //透明度が変わる速度
    float fadeSpeed = 0.02f;
    //パネルの色、透明度の管理
    float red, green, blue, alpha = 0f;

    //フェードアウト処理の開始
    public static bool isFadeOut = false;
    //フェードイン処理の開始
    public static bool isFadeIn = false;

    //フェードを反映させる画像
    public Image FadeImage;
    //キャンバス自体
    //public GameObject FadeButton1;
    //public GameObject FadeButton2;

    //シーンの名前、Inspectorで入力必須
    public string SceneName;

    // Start is called before the first frame update

    public static FadeScript Instance
    {
        get; private set;
    }

    void Awake()
    {
        //多分ここで画像が消えない処理を入れてるんだと思う、後で調べる

        //もしインスタンスが複数存在するなら、自らを破壊する
        if (Instance != null)
        {
            //消える
            Destroy(this);
            //繰り返す
            return;
        }
        //シングルトン
        Instance = this;

        //消えないようにする
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        //アタッチした画像のRGBAを入れる場所
        red = FadeImage.color.r;
        green = FadeImage.color.g;
        blue = FadeImage.color.b;
        alpha = FadeImage.color.a;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn)
        {
            //フェードイン
            StartFadeIn();
        }
        if (isFadeOut)
        {
            //フェードアウト
            StartFadeOut();
        }
    }

    void StartFadeIn()
    {
        //フェードインする

        //透明度を徐々に下げる
        alpha -= fadeSpeed;
        //変更したα値をアタッチした画像に反映させる
        SetAlpha();

        //α値が0以下になったら～
        if(alpha <= 0)
        {
            //フェードイン終了
            isFadeIn = false; 
        }
    }

    void StartFadeOut()
    {
        FadeImage.enabled = true;
        alpha += fadeSpeed;
        SetAlpha();

        if(alpha >= 1)
        {
            //フェードアウト終了
            isFadeOut = false;

            //ボタンの表示をオフ
            //FadeButton1.SetActive (false);
            //FadeButton2.SetActive (false);

            //シーン移動
            SceneManager.LoadScene(SceneName);
            //フェードイン開始
            isFadeIn = true;
        }
    }

    void SetAlpha()
    {
        //色
        FadeImage.color = new Color(red, green, blue, alpha);
        
    }
    public void FadeOutButton()
    {
        //フェードアウトを開始する（true）にする
        isFadeOut = true;
    }
}
