using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectCanvasGo : MonoBehaviour
{
    //Yes,Noの選択肢の表示、各ステージごとに用意してアタッチしていこう（）
    public GameObject SelectCanvas;
    public EventSystem SelectCanvasEvent;
    //今のキャンバス（ステージ選択）
    public Canvas Main;
    //ステージにあった星をアタッチ
    public Animator StageAnimator;
    //AnimetorのBoolにあった名前を入れる（こうしないと別々でスクリプトを組まないといけなくなる）
    public string[] AnimatorName = new string[2];

    bool canvasmove = false;

    // Start is called before the first frame update
    void Start()
    {
        StageAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //×ボタンでも戻ることができるようにするため
        if (canvasmove)
        {
            if (Input.GetButtonDown("Cancel"))
            {
                BackCanvas();
            }
        }
    }
    public void ChangeInput()
    {
        //星を選ぶシーンからYES、NOを選択するやつに移行するための

        var eventSystem = Main.GetComponent<EventSystem>();

        //星が前に出てくるアニメーション
        StageAnimator.SetTrigger(AnimatorName[0]);

        //YES/NOの選択肢をSetActive＝Trueにして、その選択によってイベントを加える
        SelectCanvas.SetActive(true);
        //YESNOを操作できないようにする
        SelectCanvasEvent.enabled = false;
        //呼び出し
        Invoke("CanvasActivefalse", 4f);
        //Mainの方のCanvasを操作できないようにする
        eventSystem.enabled = false;
    }
    void CanvasActivefalse()
    {
        //YESNOの操作を可能にする
        SelectCanvasEvent.enabled = true;
        //bool
        canvasmove = true;
    }

    public void BackCanvas()
    {
        //YES、NOの選択肢から星を選ぶやつに移行するための

        var eventSystem = Main.GetComponent<EventSystem>();

        //星が元の場所に戻るアニメーション
        StageAnimator.SetTrigger(AnimatorName[1]);

        //現時点のCanvasをfalseにする
        SelectCanvas.SetActive(false);

        Invoke("CanvasActivetrue", 4f);

        //Mainキャンバスを動かせるようにする（しないとボタンが選択できなくなる）
        //eventSystem.enabled = true;

        
    }
    void CanvasActivetrue()
    {
        var eventSystem = Main.GetComponent<EventSystem>();

        //Mainキャンバスを動かせるようにする（しないとボタンが選択できなくなる）
        eventSystem.enabled = true;
    }
}
