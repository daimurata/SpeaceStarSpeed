using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Timar : MonoBehaviour
{
    [SerializeField]
    Image[] images = new Image[4];


    [SerializeField]
    Sprite[] numberSprites = new Sprite[10];

    public float timeCount { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        SetTime(0);
    }
    public void SetTime(float time)
    {
        timeCount = time;
        StartCoroutine(TimerStart());
    }
    void SetNumbers(int sec, int val1, int val2)
    {
        string str = String.Format("{0:00}", sec);
        images[val1].sprite = numberSprites[Convert.ToInt32(str.Substring(0, 1))];
        images[val2].sprite = numberSprites[Convert.ToInt32(str.Substring(1, 1))];
    }
    IEnumerator TimerStart()
    {
        while (timeCount >= 0)
        {
            int sec = Mathf.FloorToInt(timeCount % 60);
            SetNumbers(sec, 2, 3);
            int minu = Mathf.FloorToInt((timeCount -sec) / 60);
            SetNumbers(minu, 0, 1);
            yield return new WaitForSeconds(1.0f);
            timeCount += 1.0f;
        }
     
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
}
