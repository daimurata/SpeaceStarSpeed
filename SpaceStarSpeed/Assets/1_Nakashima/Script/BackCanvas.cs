using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackCanvas : MonoBehaviour
{
    //YESNO選択キャンバス
    public GameObject YesNoCanvas;
    //前のキャンバスステージ選択
    public GameObject MainCanvas;
    

    //星のアニメーター
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CanvasDestroy()
    {
        var eventSystem = MainCanvas.GetComponent<EventSystem>();

        //現時点のCanvasをfalseにする
        YesNoCanvas.SetActive(false);

        //Mainキャンバスを動かせるようにする（しないとボタンが選択できなくなる）
        eventSystem.enabled = true;
        //MainCanvas.SetActive(true);
        //ここに星を元の場所に戻すアニメーションを入れる
        
    }
}
