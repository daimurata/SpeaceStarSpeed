using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    static public SoundManager instance;


    //タイトル画面
    public AudioClip BGM1;
    //セレクトシーン画面
    public AudioClip BGM2;
    //ゲーム画面
    public AudioClip BGM3;
    //リザルト画面
    public AudioClip BGM4;
    //ボタンを押した際のSE
    public AudioClip ButtonSE;

    //何らかのアクションを起こした際のSEを入れる（これを増やしていく）
    public AudioClip tekito;

    private AudioSource audioSource;

    int BGMFlg = 1;
    


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void StartBGM1()
    {
        audioSource.clip = BGM1;
        audioSource.Play();
        BGMFlg = 1;
    }

    public void StartBGM2()
    {
        audioSource.clip = BGM2;
        audioSource.Play();
        BGMFlg = 2;
    }

    public void StartBGM3()
    {
        audioSource.clip = BGM3;
        audioSource.Play();
        BGMFlg = 3;
    }

    public int GetBGMFlg()
    {
        return BGMFlg;
    }

    public void Soundtekito()//今後こんな感じのものをSEが増える度に増やしていく
    {
        audioSource.PlayOneShot(tekito);
    }

    public void StartButtonSE()
    {
        audioSource.PlayOneShot(ButtonSE);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
