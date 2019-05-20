using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCanvasGo : MonoBehaviour
{
    //Yes,Noの選択肢の表示、各ステージごとに用意してアタッチしていこう（）
    public GameObject SelectCanvas;
    //今のキャンバス（ステージ選択）
    public GameObject Main;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ButtonClick()
    {
        //呼ぶ
        ChangeInput();
    }
    void ChangeInput()
    {
        //YES/NOの選択肢をSetActive＝Trueにして、その選択によってイベントを加える
        SelectCanvas.SetActive(true);
        Main.SetActive(false);
    }
}
