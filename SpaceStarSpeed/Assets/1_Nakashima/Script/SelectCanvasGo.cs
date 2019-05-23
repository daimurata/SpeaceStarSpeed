﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectCanvasGo : MonoBehaviour
{
    //Yes,Noの選択肢の表示、各ステージごとに用意してアタッチしていこう（）
    public GameObject SelectCanvas;
    //今のキャンバス（ステージ選択）
    public Canvas Main;

    //ステージにあった星をアタッチ
    public Animator StageAnimator;
    //AnimetorのBoolにあった名前を入れる（こうしないと別々でスクリプトを組まないといけなくなる）
    public string[] AnimatorName = new string[2];

    //すごい雑だけど、試しでSetActiveいじる
    //選んだステージ以外falseにする、それをアタッチする
    public GameObject[] obj = new GameObject[6];
    

    // Start is called before the first frame update
    void Start()
    {
        StageAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //×ボタンでも戻ることができるようにするため
        if (Input.GetButtonDown("Cancel"))
        {
            BackCanvas();
        }
    }
    public void ChangeInput()
    {
        var eventSystem = Main.GetComponent<EventSystem>();

        //YES/NOの選択肢をSetActive＝Trueにして、その選択によってイベントを加える
        SelectCanvas.SetActive(true);
        //Mainの方のCanvasを操作できないようにする
        eventSystem.enabled = false;

        //星が前に出てくるアニメーション
        StageAnimator.SetTrigger(AnimatorName[0]);
    }

    public void BackCanvas()
    {
        var eventSystem = Main.GetComponent<EventSystem>();

        //現時点のCanvasをfalseにする
        SelectCanvas.SetActive(false);
        //Mainキャンバスを動かせるようにする（しないとボタンが選択できなくなる）
        eventSystem.enabled = true;

        //星が元の場所に戻るアニメーション
        StageAnimator.SetTrigger(AnimatorName[1]);
    }

}