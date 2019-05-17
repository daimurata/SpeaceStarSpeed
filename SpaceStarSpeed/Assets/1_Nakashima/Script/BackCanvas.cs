using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCanvas : MonoBehaviour
{
    //YESNO選択キャンバス
    public GameObject YesNoCanvas;
    //前のキャンバスステージ選択
    public GameObject MainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CanvasDestroy()
    {
        //現時点のCanvasをfalseにする
        YesNoCanvas.SetActive(false);
        MainCanvas.SetActive(true);
    }
}
